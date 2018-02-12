using FW.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FW.DataAccess.Controller
{
    public class RssConfigController
    {
        public List<RssConfig> List()
        {
            try
            {
                List<RssConfig> oListRssConfig = new List<RssConfig>();
                using (Entities db = new Entities())
                {
                    oListRssConfig = db.RssConfig.ToList(); ;
                }
                return oListRssConfig;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Add(RssConfig oRssConfig)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    db.Entry(oRssConfig).State = System.Data.Entity.EntityState.Added;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(RssConfig oRssConfig)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    //var entFeedRssConfig = db.FeedRssConfig.FirstOrDefault(x => x.IdFeedRssConfig == oRssConfig.IdFeedRssConfig);
                    //entFeedRssConfig.IdFeedRssConfig = oRssConfig.IdFeedRssConfig;
                    //entFeedRssConfig.IdSourceRss = oRssConfig.IdSourceRss;
                    //entFeedRssConfig.Url = oRssConfig.Url;
                    //db.Entry(entFeedRssConfig).State = System.Data.Entity.EntityState.Modified;
                    //db.SaveChanges();
                    db.Entry(oRssConfig).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int idRssConfig)
        {
            try
            {
                using (Entities db = new Entities())
                {
                    var entFeedRssConfig = db.RssConfig.FirstOrDefault(x => x.IdRssConfig == idRssConfig);
                    db.Entry(entFeedRssConfig).State = System.Data.Entity.EntityState.Deleted;
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
