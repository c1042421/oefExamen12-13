using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace oefenExamen12_13
{
    partial class Trein
    {
        private Spoor _spoorObject;
        private DispatcherTimer _timer1;

        private DispatcherTimer Timer1 { get => _timer1; set => _timer1 = value; }
        internal Spoor SpoorObject { get => _spoorObject; set => _spoorObject = value; }

        public Trein(string kentekennr, string bestemming, DateTime? vertrek)
        {
            Kentekennr = kentekennr;
            Bestemming = bestemming;
            Vertrek = vertrek;
            Timer1.Interval = new TimeSpan(1000);
            Timer1.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        public Trein() : this("", "", null) { }

        public void StartTimer() => Timer1.Start();

        public override string ToString() => Spoor + " - " + Bestemming + " - " + Vertrek;
      
    }
}
