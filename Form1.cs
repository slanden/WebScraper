using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace WebScraper
{
    public partial class Form1 : Form
    {
        Scraper scraper = new Scraper("http://www.realmofdarkness.net/sb/bane/");
        Dictionary<string, string> audioFiles = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void TestScrape(object sender, EventArgs e)
        {
            audioFiles = scraper.Scrape("//audio");

            //Scraper s = new Scraper();
            //s.Scrape("http://www.realmofdarkness.net/sb/bane/");

            //string url = "http://www.realmofdarkness.net/sb/bane/";
            //HtmlWeb web = new HtmlWeb();
            //HtmlAgilityPack.HtmlDocument doc = web.Load(url);

            ////HtmlDocument doc = new HtmlWeb().Load(url);
            //HtmlNodeCollection nodeList = doc.DocumentNode.SelectNodes("//audio");

            //List<string> audioFiles = new List<string>();
            //for (int i = 0; i < nodeList.Count; ++i)
            //{
            //    string s = nodeList[i].InnerHtml;
            //    s = s.Split('"', '"')[1];
            //    //audioFiles[i] = s.Split('"', '"')[1];
            //    Console.WriteLine(s);
            //}

        }
    }
}
