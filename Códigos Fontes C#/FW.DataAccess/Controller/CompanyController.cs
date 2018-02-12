using FW.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FW.DataAccess.Controller
{
   
    public class CompanyController
    {
        

        public List<Company> List()
        {
            try
            {
                List<Company> oListCompany = new List<Company>();
                using (Entities db = new Entities())
                {
                    oListCompany = db.Company.ToList(); ;
                }
                return oListCompany;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Add(Company oCompany)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    db.Entry(oCompany).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Company oCompany)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    db.Entry(oCompany).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int idCompany)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    var oCompany = db.Company.FirstOrDefault(x => x.IdCompany == idCompany);
                    db.Entry(oCompany).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
