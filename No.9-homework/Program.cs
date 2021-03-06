﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCrawler1
{
    public class SimpleCrawler
    {
        public Hashtable urls = new Hashtable();
        private int count = 0;
        public event Action<string> PageDownloaded;
        public string StartURL { get; set; }
        static void Main(string[] args)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            string startUrl = "http://www.cnblogs.com/dstang2000/";
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urls.Add(startUrl, false);//加入初始页面
            new Thread(myCrawler.Crawl).Start();
            Console.ReadKey();
        }

        public void Crawl()
        {
            Console.WriteLine("开始爬行了....  ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 100) break;
                if (!current.Contains("www.cnblogs.com/dstang2000/"))
                {
                    Console.WriteLine("爬行http://www.cnblogs.com/dstang2000/" + current + "页面!");
                }
                else
                    { Console.WriteLine("爬行" + current + "页面!"); }
                string html = DownLoad(current); // 下载
                PageDownloaded(current);
                urls[current] = true;
                count++;
                Parse(html);//解析,并加入新的链接
                Console.WriteLine("爬行结束");
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                //PageDownloaded(html);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        public void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            //Regex.Matches(sturl, "(href|HREF)[]*=[]*[""'][^""'#>]+[""']");new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                //if(urls[strRef] == null) urls[strRef] = false;
                if (urls[strRef] == null&& strRef.Contains("www.cnblogs.com/dstang2000/") && strRef.Contains(".html")) urls[strRef] = false;
               // }
            }
        }
    }   
}   
