using FW.DataAccess.Controller;
using FW.DataAccess.EntityFramework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FW.Crawler.Controller
{
    public class CrawlerController
    {
        CompanyController oCompanyController = new CompanyController();
        RssConfigController oRssConfigController = new RssConfigController();
        FeedController oFeedController = new FeedController();

        public void Execute()
        {
            try
            {
                var oListCompany = oCompanyController.List();
                var oListRssConfig = oRssConfigController.List();
                Argotic.Syndication.RssFeed feed = new Argotic.Syndication.RssFeed();
                foreach (var oRSS in oListRssConfig)
                {
                    try
                    {
                         feed = Argotic.Syndication.RssFeed.Create(new Uri(oRSS.Url));
                    }
                    catch { feed = new Argotic.Syndication.RssFeed(); }

                    foreach (var itemFeed in feed.Channel.Items)
                    {
                        foreach (var company in oListCompany)
                        {
                            Feed oFeed = new Feed();

                            if (itemFeed.Title.Contains(company.Name) || itemFeed.Description.Contains(company.Name))
                            {
                                oFeed.IdCompany = company.IdCompany;
                            }

                            string strTitle = itemFeed.Title;
                            string strDescription = itemFeed.Description;

                            oFeed.Guid = itemFeed.Link.AbsoluteUri;
                            oFeed.Title = strTitle;
                            oFeed.Description = strDescription;
                            oFeed.TitleDescription = strTitle + ". " + strDescription;
                            oFeed.Link = itemFeed.Link.AbsoluteUri;
                           // oFeed.Status = 1;

                            if (itemFeed.PublicationDate.ToString("dd/MM/yyyy") == "01/01/0001")
                                oFeed.PubDate = DateTime.Now;
                            else
                                oFeed.PubDate = itemFeed.PublicationDate;

                            oFeedController.Add(oFeed);


                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}
