using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefenExamen12_13
{
    class PassagiersTrein : Trein
    {
        private int _aantalPassagiersOpgestapt;
        private Random wilgetal;

        public int AantalPassagiersOpgestapt { get => _aantalPassagiersOpgestapt; set => _aantalPassagiersOpgestapt = value; }

        public PassagiersTrein(string kentekennr, string bestemming, DateTime vertrek, int maxAantalPassagiers, int aantalPassagiersOpgestapt): base(kentekennr,bestemming, vertrek)
        {
            MaxAantalPassagiers = maxAantalPassagiers;
            AantalPassagiersOpgestapt = aantalPassagiersOpgestapt;
        }

        public void PassagiersStappenOp() => AantalPassagiersOpgestapt = wilgetal.Next(0, MaxAantalPassagiers ?? 0);
    }
}
