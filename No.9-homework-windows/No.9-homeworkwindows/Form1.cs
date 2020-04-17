using System;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace No._9_homeworkwindows
{
    public partial class Form1 : Form
    {
        SimpleCrawler crawler = new SimpleCrawler();
        public Form1()
        {
            InitializeComponent();
            crawler.PageDownloaded += Crawler_PageDownloaded;
        }
        private void Crawler_PageDownloaded(string url)
        {
            if (this.listBox1.InvokeRequired)
            {
                Action<String> action = this.AddUrl;
                this.Invoke(action, new object[] { url });
            }
            else
            {
                AddUrl(url);
            }
        }
        private void AddUrl(string url)
        {
            listBox1.Items.Add(url);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            crawler.StartURL =textBox1.Text;
            listBox1.Items.Clear();
            new Thread(crawler.Crawl).Start();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    class SimpleCrawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        public Action<string> PageDownloaded;
        public string StartURL { get; set; }
        public int a { get; set; }
        //private string sturl = "http://www.cnblogs.com/dstang2000/";
       /* static void Main(string[] args)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            string startUrl = "http://www.cnblogs.com/dstang2000/";
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urls.Add(startUrl, false);//加入初始页面
            new Thread(myCrawler.Crawl).Start();
            Console.ReadKey();
        }*/

        public void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 10) break;
                
                Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current); // 下载
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
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html)
        {
            // string html1 = wc.DownloadString("http://www.cnblogs.com/dstang2000/";
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            //Regex.Matches(sturl, "(href|HREF)[]*=[]*[""'][^""'#>]+[""']");new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                //if (strRef.Contains(sturl))
                //{
                if (urls[strRef] == null && strRef.Contains("www.cnblogs.com/dstang2000/") && strRef.Contains(".html")) urls[strRef] = false;
                // }
            }
        }
    }

}
