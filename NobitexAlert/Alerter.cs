using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NobitexAlert
{
    public class Alerter
    {
        private double abovePrice = 0;
        private double belowPrice = 0;
        private uint totalAlertsDone = 0;
        private readonly uint alertTimes = 1;
        private uint remainingAlerts = 0;
        private bool isEnable = true;
        private bool isBusy = false;

        public Alerter(double above, double below, uint alerttimes, bool isEnable = true)
        {
            this.abovePrice = above;
            this.belowPrice = below;
            this.alertTimes = alerttimes;
            this.remainingAlerts = alerttimes;
            this.isEnable = isEnable;
        }

        public void Enable() => isEnable = true;
        public void Disable() => isEnable = false;
        public bool IsEnabled() => isEnable == true;
        public void Reset()
        {
            remainingAlerts = alertTimes;
            Enable();
        }

        public bool IsBusy() => isBusy;
        public void Alert(double price)
        {
            if (IsEnabled() == false)
                return;
            if (price > belowPrice && price < abovePrice)
            {
                Reset();
                return;
            }

            isBusy = true;
            for (int i = 1; i <= remainingAlerts; i++)
            {
                System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
                System.IO.Stream s = a.GetManifestResourceStream("NobitexAlert.Alerts.alert3.wav");
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(s);
                player.PlaySync();
            }
            totalAlertsDone++;
            isBusy = false;
        }
    }
}
