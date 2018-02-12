using FW.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FW.DataAccess.Controller
{
    public class QuotationController
    {
        public List<Quotation> List()
        {
            try
            {
                List<Quotation> oListQuotation = new List<Quotation>();
                using (Entities db = new Entities())
                {
                    oListQuotation = db.Quotation.ToList(); ;
                }
                return oListQuotation;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Quotation> List(string CodCompany)
        {
            try
            {
                List<Quotation> oListQuotation = new List<Quotation>();
                using (Entities db = new Entities())
                {
                    oListQuotation = db.Quotation.Where(x => x.CodCompany == CodCompany).OrderBy(x=>x.Date).ToList();
                }
                return oListQuotation;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
