using FW.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FW.DataAccess.Controller
{
    public class StopWordsController
    {
        public List<StopWords> List()
        {
            try
            {
                List<StopWords> oStopWordsList = new List<StopWords>();
                using (Entities db = new Entities())
                {
                    oStopWordsList = db.StopWords.ToList(); ;
                }
                return oStopWordsList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
