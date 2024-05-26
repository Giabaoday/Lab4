using Newtonsoft.Json.Linq;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            string url = tburl.Text;
            string username = tbusername.Text;
            string password = tbpassword.Text;

            using (HttpClient client = new HttpClient())
            {
                var content = new MultipartFormDataContent();
                content.Add(new StringContent(username), "username");
                content.Add(new StringContent(password), "password");

                var response = await client.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();
                var jObject = JObject.Parse(responseString);
                var token_type = jObject["token_type"]?.ToString();
                var access_token = jObject["access_token"]?.ToString();

                if (!response.IsSuccessStatusCode)
                {
                    richTextBox1.AppendText("Lỗi đăng nhập");
                    return;
                }
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(token_type, access_token);
                var getUserUrl = "https://nt106.uitiot.vn/api/v1/user/me";
                var getUserResponse = await client.GetAsync(getUserUrl);
                var getUserResponseString = await getUserResponse.Content.ReadAsStringAsync();
                richTextBox1.AppendText(getUserResponseString);
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            tbusername.Text = "";
            tbpassword.Text = "";
            richTextBox1.Text = "";
        }
    }
}
