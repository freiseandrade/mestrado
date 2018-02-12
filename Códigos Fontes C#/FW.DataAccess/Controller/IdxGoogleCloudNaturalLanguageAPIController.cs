using FW.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FW.DataAccess.Controller
{
    public class IdxGoogleCloudNaturalLanguageAPIController
    {
        public void Add(IdxGoogleCloudNaturalLanguageAPI oIdxGoogleCloudNaturalLanguageAPI)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    db.Entry(oIdxGoogleCloudNaturalLanguageAPI).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                StringBuilder sb = new StringBuilder();

                foreach (var eve in e.EntityValidationErrors)
                {
                    sb.AppendLine(String.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:", eve.Entry.Entity.GetType().Name, eve.Entry.State));

                    foreach (var ve in eve.ValidationErrors)
                    {
                        sb.AppendLine(String.Format("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage));
                    }
                }

                //throw new Exception(sb.ToString());
            }
            catch (Exception ex)
            {
                //throw ex;
            }
        }
    }
}
