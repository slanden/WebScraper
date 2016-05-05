using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WebScraper
{
    public class Scraper
    {
        string url;
        HtmlWeb webRequest = new HtmlWeb();             //web request object to talk to internet
        HtmlDocument doc;                               //html document to save in memory

        Scraper() { }

        public Scraper(string a_url)
        {
            url = a_url;
            doc = webRequest.Load(url);
        }        

        public Dictionary<string, string> Scrape(string xPath)
        {
            Dictionary<string, string> audioFiles = new Dictionary<string, string>();
            HtmlNodeCollection nodeList = doc.DocumentNode.SelectNodes("//audio");
            
            foreach(HtmlNode node in nodeList)
            {
                //string s = node.InnerHtml;
                //s = s.Split('"', '"')[1];
                audioFiles.Add(node.Id, node.InnerHtml.Split('"', '"')[1]);
            }

            ///foreach is faster when accessing the item from the array more than once
            //for(int i = 0; i < nodeList.Count; ++i)
            //{
            //    string s = nodeList[i].InnerHtml;
            //    s = s.Split('"', '"')[1];
            //    audioFiles.Add(nodeList[i].Id,s);
            //}
            return audioFiles;
            //if (doc.ParseErrors != null && doc.ParseErrors.Count() > 0)
            //{

            //}
            //else if(doc.DocumentNode != null)
            //{
            //    HtmlNode node = doc.DocumentNode.SelectSingleNode("//body");

            //    HtmlNodeCollection nodeList = doc.DocumentNode.SelectNodes("//body");

            //    if (nodeList != null)
            //        Console.WriteLine(nodeList.Count);

            //    //foreach (HtmlNode n in nodeList)
            //    //{
            //    //    if (n != null)
            //    //    {
            //    //        Console.WriteLine("Shit yeah!");
            //    //    }
            //    //    else
            //    //    {
            //    //        Console.WriteLine("Shit.");
            //    //    }
            //    //}


            //}
        }
    }
}
