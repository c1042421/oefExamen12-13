using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefenExamen12_13
{
    class Spoor
    {
        private string _scherm;
        private int _spoornr;
        private bool _vrij;

        public Spoor(int spoornr, bool vrij)
        {
            Spoornr = spoornr;
            Vrij = vrij;
        }

        public string Scherm { get => _scherm; set => _scherm = value; }
        public int Spoornr { get => _spoornr; set => _spoornr = value; }
        public bool Vrij { get => _vrij; set => _vrij = value; }
    }
}
