using FW.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;

namespace FW.DataAccess.Controller
{
    public class FeedController
    {
        public List<Feed> List()
        {
            try
            {
                List<Feed> oListRssConfig = new List<Feed>();
                using (Entities db = new Entities())
                {
                    oListRssConfig = db.Feed.ToList(); ;
                }
                return oListRssConfig;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Feed> List(int idCompany)
        {
            try
            {
                List<Feed> oListRssConfig = new List<Feed>();
                using (Entities db = new Entities())
                {
                    oListRssConfig = db.Feed.Where(x => x.IdCompany == idCompany).ToList();
                }
                return oListRssConfig;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Feed> List(int idCompany, int? statusCode)
        {
            try
            {
                List<Feed> oListRssConfig = new List<Feed>();
                using (Entities db = new Entities())
                {
                    oListRssConfig = db.Feed.Where(x => x.IdCompany == idCompany && x.Status== statusCode).ToList();
                }
                return oListRssConfig;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Add(Feed oFeed)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    db.Entry(oFeed).State = System.Data.Entity.EntityState.Added;
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

        public void Update(Feed oFeed)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    db.Entry(oFeed).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(string guid)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    var oFeed = db.Feed.FirstOrDefault(x => x.Guid == guid);
                    db.Entry(oFeed).State = System.Data.Entity.EntityState.Deleted;
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
