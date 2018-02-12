using FW.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FW.DataAccess.Controller
{
    public class V_IBM_WatsonToneAnalyzerController
    {
        public List<V_IBM_WatsonToneAnalyzer> List()
        {
            try
            {
                List<V_IBM_WatsonToneAnalyzer> oListFeedPos = new List<V_IBM_WatsonToneAnalyzer>();
                using (Entities db = new Entities())
                {
                    oListFeedPos = db.V_IBM_WatsonToneAnalyzer.ToList();
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
