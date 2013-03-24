using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace GoogleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string query = "http://www.google.co.uk/search?hl=en&q={0}gbp+in+hkd&meta=&aq=f&oq=";
            query = string.Format(query, "40");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(query);
            request.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US; rv:1.8.1.4) Gecko/20070515 Firefox/2.0.0.4";
            string html;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if ((request.HaveResponse) && (response.StatusCode == HttpStatusCode.OK))
                {
                    using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                    {
                        html = sr.ReadToEnd();

                        Regex regex = new Regex(@"<b>\d*\ .*=.*dollars</b>");
                        MatchCollection results = regex.Matches(html);
                        Console.WriteLine(results[0].ToString());

                    }
                }
            }
        }
    }
}
