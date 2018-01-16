using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace oefenExamen12_13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dm = new DataManager();
        }

        DataManager dm;

        private void btnBekijk_Click(object sender, RoutedEventArgs e)
        {
            List<PassagiersTrein> treinen = dm.GetTreingegevens();
            Dictionary<string, TreeViewItem> itemsDict = new Dictionary<string, TreeViewItem>();
            

            bool byBestemming = rbBestemming.IsChecked.Value;

            if (byBestemming)
            {
                treinen.Sort(CompareItemsByPlace);
            }else
            {
                treinen.Sort(CompareItemsBySpoor);
            }

            foreach (Trein trein in treinen)
            {
                if (byBestemming)
                {
                    if (!itemsDict.ContainsKey(trein.Bestemming))
                    {
                        itemsDict.Add(trein.Bestemming, new TreeViewItem()
                        {
                            Title = trein.Bestemming
                        });
                    }

                    itemsDict[trein.Bestemming].SubItems.Add(new SubTreeViewItem()
                    {
                        Title = trein.SpoorObject.Spoornr + " - " + trein.Vertrek
                    });

                }else
                {
                    string spoorNr = trein.SpoorObject.Spoornr.ToString();

                    if (!itemsDict.ContainsKey(spoorNr))
                    {
                        itemsDict.Add(spoorNr ,new TreeViewItem()
                        {
                            Title = spoorNr
                        });
                    }

                    itemsDict[spoorNr].SubItems.Add(new SubTreeViewItem()
                    {
                        Title = trein.Bestemming + " - " + trein.Vertrek
                    });
                }
            }

            List<TreeViewItem> items = itemsDict.Values.ToList();
            //TODO sort by title
            

            treeTreinen.ItemsSource = itemsDict.Values;
        }

        private int CompareItemsBySpoor(Trein x, Trein y)
        {
            if (x.Spoor == null || y.Spoor == null) return 0;
            
            return x.Spoor.Value.CompareTo(y.Spoor.Value);
        }

        private int CompareItemsByPlace(Trein x, Trein y)
        {
           return x.Bestemming.CompareTo(y.Bestemming);
        }
    }
}
