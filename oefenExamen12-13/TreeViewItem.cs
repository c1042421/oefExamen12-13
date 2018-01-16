using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefenExamen12_13
{
    class TreeViewItem
    {
        private string _title;
        private List<SubTreeViewItem> subItems;

        public TreeViewItem()
        {
            subItems = new List<SubTreeViewItem>();
        }

        public string Title { get => _title; set => _title = value; }
        public List<SubTreeViewItem> SubItems { get => subItems; set => subItems = value; }

        public override string ToString() => Title;
        
    }
}
