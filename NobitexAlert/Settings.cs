using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NobitexAlert
{
    public partial class Settings : Form
    {
        public static string CryptoSymbol = "BTC";
        public Settings()
        {
            InitializeComponent();
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CryptoSymbol = txtSymbol.Text;
            Properties.Settings.Default.AlertEnabled = chkEnableAlert.Checked;
            Properties.Settings.Default.AlertAtAbovePrice = double.Parse(txtAbove.Text, CultureInfo.InvariantCulture);
            Properties.Settings.Default.AlertAtBelowPrice = double.Parse(txtBelow.Text, CultureInfo.InvariantCulture);
            Properties.Settings.Default.AlertTimes = (uint)numUpDwnAlertTimes.Value;
            Properties.Settings.Default.UpdateInterval = (uint)numUpDwnUpdateInterval.Value;
            Properties.Settings.Default.Currency = GetRadioButtonsValue();
            Properties.Settings.Default.Save();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            txtSymbol.Text = Properties.Settings.Default.CryptoSymbol;
            numUpDwnOpacity.Value =(int) (Properties.Settings.Default.Opacity * 100);
            chkEnableAlert.Checked = Properties.Settings.Default.AlertEnabled;
            txtAbove.Text = Properties.Settings.Default.AlertAtAbovePrice.ToString();
            txtBelow.Text = Properties.Settings.Default.AlertAtBelowPrice.ToString();
            numUpDwnAlertTimes.Value = Properties.Settings.Default.AlertTimes;
            numUpDwnUpdateInterval.Value = Properties.Settings.Default.UpdateInterval;
            SetRadioButtonsValue(Properties.Settings.Default.Currency);
        }

        private void numUpDwnOpacity_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Opacity = (float) (numUpDwnOpacity.Value / 100);
            this.Owner.Opacity = Properties.Settings.Default.Opacity;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void txtSymbol_TextChanged(object sender, EventArgs e)
        {
            chkEnableAlert.Checked = false;
        }

        private uint GetRadioButtonsValue()
        {
            if (radiobtnIRT.Checked)
                return 0;
            else if (radiobtnRIAL.Checked)
                return 1;
            else if (radiobtnUSDT.Checked)
                return 2;
            //radiobtnGlobal.Checked
            return 3;
        }

        private void SetRadioButtonsValue(uint value=0)
        {
            switch (value)
            {
                case 0:
                    radiobtnIRT.Checked = true; 
                    break;
                case 1:
                    radiobtnRIAL.Checked = true;
                    break;
                case 2:
                    radiobtnUSDT.Checked = true;
                break;
                default:
                    radiobtnGlobal.Checked = true;
                    break;
            }
        }
    }
}
