using FW.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FW.DataAccess.Controller
{
    public class V_Google_CloudNaturalLanguageAPIController
    {
        public List<V_Google_CloudNaturalLanguageAPI> List()
        {
            try
            {
                List<V_Google_CloudNaturalLanguageAPI> oListFeedPos = new List<V_Google_CloudNaturalLanguageAPI>();
                using (Entities db = new Entities())
                {
                    oListFeedPos = db.V_Google_CloudNaturalLanguageAPI.ToList();
                }
                return oListFeedPos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
