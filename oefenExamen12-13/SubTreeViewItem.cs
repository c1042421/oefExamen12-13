using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefenExamen12_13
{
    class SubTreeViewItem
    {
        private string _title;

        public string Title { get => _title; set => _title = value; }

        public override string ToString() => Title;
       
    }
}
