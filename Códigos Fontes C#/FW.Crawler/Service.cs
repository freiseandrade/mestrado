using FW.Crawler.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FW.Crawler
{
    public partial class Service : ServiceBase
    {
        CrawlerController oCrawlerController = new CrawlerController();
        public Service()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            var timeInSeconds = ConfigurationManager.AppSettings["Time"];
            timer.Interval = double.Parse(timeInSeconds);
            timer.Enabled = true;
        }
        protected override void OnStop()
        {
            timer.Enabled = false;
        }
        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            timer.Stop();
            oCrawlerController.Execute();
            timer.Start();
        }
    }
}
//timerInclusaoDossie.Stop();
//oProcesso.ProcessarArquivos();
//timerInclusaoDossie.Start();