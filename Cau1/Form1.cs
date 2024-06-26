using System.Net;
using System.Security.Policy;

namespace Cau1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            string htmlContent = getHTML(url);
            richTextBox1.Text = htmlContent;
        }
        private string getHTML(string szURL)
        {
            // Create a request for the URL. 
            WebRequest request = WebRequest.Create(szURL);
            // Get the response.   
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server.  
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.   
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.   
            string responseFromServer = reader.ReadToEnd();
            // Close the response.   
            response.Close();
            return responseFromServer;
        }
    }
    }
