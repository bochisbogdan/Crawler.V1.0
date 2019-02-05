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
using Auto_Finde.Functions;

namespace Auto_Finde
{
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
