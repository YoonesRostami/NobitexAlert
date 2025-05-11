using NoobsMuc.Coinmarketcap.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NobitexAlert
{
    public partial class Form1 : Form
    {
        //TODO: Standad Bullish Divergence and the other 3 divergences on code, scan it and then alert for it
        //TODO: Do some technical analysis on the coin bars and alert if you find a good position to enter or even to sell
        //youtube.com/watch?v=QMMVdEhz89A

        #region Win32 API Imports
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture(); 
        #endregion

        //################## Start of my own variables ####################
        // The timer.
        private System.Threading.Timer TheTimer = null;

        private uint timerUpdateTick = 0;
        private int updateInterval = 25000;

        private Alerter alerter;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region UI Things
            ShowInTaskbar = false;
            label1.Width = 4;
            lblLastUpdate.Left = label1.Width + 1;
            lblPrice.Left = label1.Width + 1;
            int gap = 5;
            int calcTotalHeight = lblLastUpdate.Height + lblPrice.Height + gap;
            lblPrice.Top = 0;
            lblLastUpdate.Top = lblPrice.Height + (int)(gap / 2);
            Height = calcTotalHeight;
            Opacity = Properties.Settings.Default.Opacity;
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            #endregion


            alerter = new Alerter(Properties.Settings.Default.AlertAtAbovePrice,
                                    Properties.Settings.Default.AlertAtBelowPrice,
                                    Properties.Settings.Default.AlertTimes,
                                    Properties.Settings.Default.AlertEnabled);
            
            // Make the timer start now and tick every 1000 ms.
            TheTimer = new System.Threading.Timer(this.Tick, null, 0, 1000);

            updateInterval = (int) Properties.Settings.Default.UpdateInterval;
            timer1.Interval = updateInterval;
            timer1.Start();
            timer1_Tick(null, null);
        }

        private void Tick(object info)
        {
            this.Invoke((Action)this.UpdateLableColor);
        }
        private void UpdateLableColor()
        {
            timerUpdateTick += 1000;
            if (timerUpdateTick >= updateInterval)
                timerUpdateTick = 0;
            int calcColor = 255 - ((int)((255 * timerUpdateTick) / updateInterval));
            label1.BackColor = Color.FromArgb(0, calcColor, 0);

            if(Application.OpenForms.OfType<Settings>().Count() == 0)
                SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                
                //ICoinmarketcapClient client = new CoinmarketcapClient("62652b52-840f-45ed-82b1-013ae59bd019");
                //Currency currency = client.GetCurrencyBySymbol(Properties.Settings.Default.CryptoSymbol);
                
                
                //lblPrice.Text = currency.Price.ToString("0.##");
                //lblLastUpdate.Text = currency.LastUpdated.ToLocalTime().ToString("MM/dd HH:mm");

                //if(alerter.IsBusy() == false)
                //    Task.Factory.StartNew(() => alerter.Alert(currency.Price));

                //https://api.nobitex.ir/market/stats?srcCurrency=btc&dstCurrency=rls
                //https://api.nobitex.ir/market/stats?srcCurrency=btc&dstCurrency=irt
                NobitexClient client = new NobitexClient();
                string price = Task.Run(() => client.GetCurrencyBySymbolAsync(Properties.Settings.Default.CryptoSymbol, 
                    (NobitexClient.CurrencySource)Properties.Settings.Default.Currency)).Result;

                lblPrice.Text = price;
                lblLastUpdate.Text = DateTime.Now.ToLocalTime().ToString("MM/dd HH:mm");

                if (alerter.IsBusy() == false)
                    Task.Factory.StartNew(() => alerter.Alert(double.Parse(price)));
            }
            catch (Exception)
            {
                lblPrice.Text = lblLastUpdate.Text = "ERROR";
            }
            int maxWidth = Math.Max(lblLastUpdate.Width, lblPrice.Width) + label1.Width + 3;

            Width = maxWidth;
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TheTimer != null) TheTimer.Dispose();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Settings settings = new Settings();
                if (settings.ShowDialog(this) == DialogResult.OK)
                {
                    alerter = new Alerter(Properties.Settings.Default.AlertAtAbovePrice,
                                          Properties.Settings.Default.AlertAtBelowPrice,
                                          Properties.Settings.Default.AlertTimes,
                                          Properties.Settings.Default.AlertEnabled);
                    timer1_Tick(null, null);
                }
            }

        }
    }
}
