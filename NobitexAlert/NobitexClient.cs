using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NobitexAlert
{
    public class NobitexClient
    {
        public NobitexClient()
        {
            if (client == null)
            {
                HttpClientHandler handler = new HttpClientHandler()
                {
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate,
                    ClientCertificateOptions = ClientCertificateOption.Manual,
                    ServerCertificateCustomValidationCallback = (httpRequestMessage, cert, certChain, policyErrors) => true
                };
                client = new HttpClient(handler);
                client.Timeout = TimeSpan.FromSeconds(5);
            }
        }
        private static HttpClient client = null;
        public enum CurrencySource
        {
            IRT = 0,
            RIAL = 1,
            USDT = 2,
            GLOBAL = 3,
        }
        public async Task<string> GetCurrencyBySymbolAsync(string symbol, CurrencySource currencySource=CurrencySource.IRT)
        {
            string url = $"https://api.nobitex.ir/market/stats?srcCurrency={symbol}";

            if (currencySource == CurrencySource.IRT)
                url += "&dstCurrency=irt";
            else if (currencySource == CurrencySource.RIAL)
                url += "&dstCurrency=rls";
            else
                url += "&dstCurrency=usdt";
            
            string response = await DownloadUrl(url);
            using var jsonParse = JsonDocument.Parse(response);
            string price = "";
            switch (currencySource)
            {
                case CurrencySource.IRT:
                    price = jsonParse.RootElement.GetProperty("stats").EnumerateObject().First().Value.GetProperty("latest").GetString();
                    return (int.Parse(price) / 10).ToString();
                case CurrencySource.RIAL:
                    price = jsonParse.RootElement.GetProperty("stats").EnumerateObject().First().Value.GetProperty("latest").GetString();
                    return (int.Parse(price) / 10).ToString();
                case CurrencySource.USDT:
                    return jsonParse.RootElement.GetProperty("stats").EnumerateObject().First().Value.GetProperty("latest").GetString();
                case CurrencySource.GLOBAL:
                default:
                    return price = jsonParse.RootElement.GetPropertyIgnoreCase("global").EnumerateObject().First().Value.GetPropertyIgnoreCase(symbol).GetDecimal().ToString();

                    
            }
        }


        private async Task<string> DownloadUrl(string url)
        { 

            using (var response = await client.GetAsync(new Uri(url)))
            {
                string result = await response.Content.ReadAsStringAsync();
                return result;
            }
            
        }
    }

    public static class JsonElementExtensions
    {
        public static JsonElement GetPropertyIgnoreCase(this JsonElement element, string propertyName)
        {
            var property = element
                .EnumerateObject()
                .FirstOrDefault(p => p.Name.Equals(propertyName, StringComparison.InvariantCultureIgnoreCase));

            return element.GetProperty(property.Name);
        }
    }
}
