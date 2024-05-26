using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Cau3
{
    public partial class sourceViewer : Form
    {
        private string URL;
        public sourceViewer(string URL)
        {
            InitializeComponent();
            this.URL = URL;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /*private void sourceViewer_Load(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create(this.URL);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            richTextBox1.Text = responseFromServer;
            response.Close();
        }*/

        private void sourceViewer_Load_1(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create(this.URL);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            richTextBox1.Text = responseFromServer;
            response.Close();
        }
    }
}
