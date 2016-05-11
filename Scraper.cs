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

        public List<string> Scrape(string xPathStartNode, string xPath)
        {
            List<string> nodes = new List<string>();
            HtmlNode startNode = doc.DocumentNode.SelectSingleNode(xPathStartNode);
            //HtmlNodeCollection nodeList = doc.DocumentNode.SelectNodes(xPath);
            HtmlNodeCollection nodeList = startNode.SelectNodes(xPath);

            foreach (HtmlNode node in nodeList)
            {
                string s = node.InnerHtml;
                //s = s.Split('"', '"')[1];
                //nodes.Add(node.Id, node.InnerHtml.Split('"', '"')[1]);
            }

            ///foreach is faster when accessing the item from the array more than once
            //for(int i = 0; i < nodeList.Count; ++i)
            //{
            //    string s = nodeList[i].InnerHtml;
            //    s = s.Split('"', '"')[1];
            //    audioFiles.Add(nodeList[i].Id,s);
            //}
            return nodes;
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
