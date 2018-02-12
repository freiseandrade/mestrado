using FW.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FW.DataAccess.Controller
{
    public class FeedPosController
    {


        public FeedPos Find(int idFeedPos)
        {
            FeedPos oFeedPos = new FeedPos();
            try
            {
                using (Entities db = new Entities())
                {
                    oFeedPos = db.FeedPos.FirstOrDefault(x => x.IdFeedPos == idFeedPos);
                }
                return oFeedPos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<FeedPos> List()
        {
            try
            {
                List<FeedPos> oListFeedPos = new List<FeedPos>();
                using (Entities db = new Entities())
                {
                    oListFeedPos = db.FeedPos.ToList();
                }
                return oListFeedPos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<FeedPos> List(int status, int quantidadeRetorno)
        {
            try
            {
                List<FeedPos> oListFeedPos = new List<FeedPos>();
                using (Entities db = new Entities())
                {
                    oListFeedPos = db.FeedPos.Where(x => x.Status == status).Take(quantidadeRetorno).ToList();
                }
                return oListFeedPos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }






        public List<FeedPos> List(int idCompany, DateTime startDate, DateTime endDate)
        {
            try
            {
                List<FeedPos> oListFeedPos = new List<FeedPos>();
                using (Entities db = new Entities())
                {
                    oListFeedPos = db.FeedPos.Where(x=>x.IdCompany==idCompany && (x.PubDate >= startDate && x.PubDate <= endDate)).OrderBy(x=>x.PubDate).ToList(); ;
                }
                return oListFeedPos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Add(FeedPos oFeedPos)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    db.Entry(oFeedPos).State = System.Data.Entity.EntityState.Added;
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

        public void Update(FeedPos oFeedPos)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    db.Entry(oFeedPos).State = System.Data.Entity.EntityState.Modified;
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public void Delete(string guid)
        //{
        //    try
        //    {
        //        using (Entities db = new Entities())
        //        {
        //            var oFeedPos = db.FeedPos.FirstOrDefault(x => x.Guid == guid);
        //            db.Entry(oFeedPos).State = System.Data.Entity.EntityState.Deleted;
        //            db.SaveChanges();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
