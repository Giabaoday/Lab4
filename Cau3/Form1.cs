using System.ComponentModel;
using System.Net;
using System.Xml;
using System.IO;
using System;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Threading.Tasks;
using System;
namespace Cau3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            WebBrowser wb = new WebBrowser();
            panel2.Controls.Add(wb);

            wb.Height = panel2.Height;
            wb.Width = panel2.Width;

            string url = textBox6.Text;
            wb.Navigate(url);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox6.Text = "https://www.google.com";
            textBox5.Text = "D:/Download";
        }

        private void viewSourceBtn_Click(object sender, EventArgs e)
        {

            sourceViewer view = new sourceViewer(textBox6.Text);
            view.Show();
        }

        void downBtn(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Tải xuống thành công");
        }
        private async void button3_Click(object sender, EventArgs e)
        {
            string base_url = textBox6.Text;
            string dir_path = textBox5.Text;
            string defaultDirectory = "D:/Download";

            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = await web.LoadFromWebAsync(base_url);

            WebClient myClient = new WebClient();
            myClient.DownloadFileCompleted += downBtn;

            HtmlNodeCollection imgNodes = document.DocumentNode.SelectNodes("//img[@src]");
            if (imgNodes != null)
            {
                foreach (HtmlNode imgNode in imgNodes)
                {
                    string imgUrl = imgNode.Attributes["src"].Value;
                    string fileName = Path.GetFileName(imgUrl);
                    if (fileName != null)
                    {
                        string destinationPath = Path.Combine(defaultDirectory, fileName);
                        try
                        {
                            await myClient.DownloadFileTaskAsync(new Uri($"{base_url}/{imgUrl}"), destinationPath);
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                }
            }

            HtmlNodeCollection linkNodes = document.DocumentNode.SelectNodes("//a[@src]");
            if (linkNodes != null)
            {
                foreach (HtmlNode linkNode in linkNodes)
                {
                    string fileUrl = linkNode.Attributes["href"].Value;
                    string fileName = Path.GetFileName(fileUrl);
                    if (fileName != null)
                    {
                        string destinationPath = Path.Combine(defaultDirectory, fileName);
                        try
                        {
                            await myClient.DownloadFileTaskAsync(new Uri($"{base_url}/{fileUrl}"), destinationPath);
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                }
            }

            myClient.DownloadFileTaskAsync(new Uri(base_url), $"{dir_path}/download.html");
        
    }
    }
}
