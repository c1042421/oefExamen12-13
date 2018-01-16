using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefenExamen12_13
{
    class DataManager
    {
        public List<PassagiersTrein> GetTreingegevens()
        {
            List<PassagiersTrein> treinen = new List<PassagiersTrein>();
            try
            {
                using (var entities = new TreinEntities())
                {
                    var query = from PassagiersTrein in entities.tblTreinen select PassagiersTrein;

                    foreach (Trein trein in query.ToList())
                    {
                        if (trein.Vertrek != null && trein.MaxAantalPassagiers != null && trein.Spoor != null)
                        {
                            Spoor spoorObj = new Spoor(trein.Spoor.Value, true);

                            PassagiersTrein passagiersTrein = new PassagiersTrein(
                            trein.Kentekennr,
                            trein.Bestemming,
                            trein.Vertrek.Value,
                            trein.MaxAantalPassagiers.Value,
                            0);

                            passagiersTrein.SpoorObject = spoorObj;

                            treinen.Add(passagiersTrein);
                        }
                    }
                    return treinen;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }


        }
    }
}
