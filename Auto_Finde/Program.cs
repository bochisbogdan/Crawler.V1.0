using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using System.Threading;
namespace Auto_Finde
{
    public static class CrawlerFunctions
    {
        public static HtmlDocument GetHtml(this String link, string user_agent)
        {
            var doc = new HtmlDocument();
            try
            {
                using (WebClient wbc = new WebClient())
                {
                    //var user_agentNotNull = user_agent.HasValue ? user_agent.Value : String.Empty;
                    wbc.Headers.Add("user-agent", user_agent);
                    string html = wbc.DownloadString(link);
                    doc.LoadHtml(html);

                    return doc;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Thread.Sleep(1500);
                GetHtml(link, user_agent);
                return new HtmlDocument();
            }
        }

        public static MatchCollection getMatches(this string text,string regex)
        {
           
            var matches= new Regex(regex).Matches(text);
            if(matches.Count==0)
                Console.WriteLine("Matches not found.");
            return matches;
        }
        public static Match getMatch(this string text, string regex)
        {
            
            var match = new Regex(regex).Match(text);
            if(match.Value == null)
                Console.WriteLine("Match not found");

            return match;
        }
        
    }

    class Program
    {
       

        
        static void Main(string[] args)
        {
            var text = "123 asd , sdfaw,f,asef,wser,fw,ef,wefwef,rwe,   Bochis ,fw,ef,wefd,wefwkipoolwlllwk,";
            var rgx = "Bochis";
            var a = text.getMatch(rgx);
            Console.WriteLine(a.Value);
            Console.ReadLine();
        }

        
    }
}
