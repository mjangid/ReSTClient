using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;


namespace ReSTClient
{
    public partial class FrmMain : Form
    {
        string url_string;
        HttpClient httpClient;

        public FrmMain()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

            MoveControls();
        }

        void MoveControls()
        {
            // tab control position
            tabControl1.Top = 50;
            tabControl1.Left = 5;
            tabControl1.Width = this.Width - 5;
            tabControl1.Height = this.Height - 60;

            richTextBox1.Top = 5;
            richTextBox1.Left = 5;
            richTextBox1.Width = tabControl1.Width - 40;
            richTextBox1.Height = tabControl1.Height - 70;

            comboBox1.Left = 5;
            comboBox1.Top = 5;
            comboBox1.Height = 40;
            comboBox1.Width = 95;

            textBox1.Left = 105;
            textBox1.Top = 5;
            textBox1.Height = 40;
            textBox1.Width = this.Width - 200;

            button1.Left = this.Width - 85;
            button1.Top = 5;
            button1.Height = 40;
            button1.Width = 60;

        }
        private void OnSize(object sender, EventArgs e)
        {
            MoveControls();
        }

        private async void OnSend(object sender, EventArgs e)
        {
            try
            {
                string responseBodyAsText;
                string url_string = textBox1.Text;

                if (comboBox1.SelectedIndex == 4)
                {
                    tabControl1.SelectedIndex = 2;
                    xmlView.Navigate(url_string);
                    return;
                }

                httpClient = new HttpClient();

                var byteArray = Encoding.ASCII.GetBytes(txtUserName.Text + ":" + txtPassword.Text);
                var header = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                httpClient.DefaultRequestHeaders.Authorization = header;



                HttpResponseMessage response = await httpClient.GetAsync(url_string);
                response.EnsureSuccessStatusCode();
                responseBodyAsText = await response.Content.ReadAsStringAsync();
                responseBodyAsText = responseBodyAsText.Replace("<br>", Environment.NewLine); // Insert new lines
                richTextBox1.Text = responseBodyAsText;
                xmlView.Navigate(url_string);
            }
            catch (HttpRequestException hre)
            {
                richTextBox1.Text = hre.ToString();
            }
            catch (Exception ex)
            {
                richTextBox1.Text = ex.ToString();
            }
        }

        private void OnClickTab(object sender, EventArgs e)
        {
            
        }

        private void OnRawText(object sender, EventArgs e)
        {

        }

        private void OnLinks(object sender, EventArgs e)
        {

        }

        private void OnXMLView(object sender, EventArgs e)
        {

        }

        private void OnAuthentication(object sender, EventArgs e)
        {
            
        }

        private void OnHeader(object sender, EventArgs e)
        {

        }

        private void OnOAuth(object sender, EventArgs e)
        {

        }

        private void SetLink(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel link = (LinkLabel) sender;
            textBox1.Text = link.Text;
        }
    }
}

/*

 * XmlTextReader reader = new XmlTextReader(@"c:\test2\1.xml");
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        this.richTextBox1.SelectionColor = Color.Blue;
                        this.richTextBox1.AppendText("<");
                        this.richTextBox1.SelectionColor = Color.Brown;
                        this.richTextBox1.AppendText(reader.Name);
                        this.richTextBox1.SelectionColor = Color.Blue;
                        this.richTextBox1.AppendText(">");
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        this.richTextBox1.SelectionColor = Color.Black;
                        this.richTextBox1.AppendText(reader.Value);
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                        this.richTextBox1.SelectionColor = Color.Blue;
                        this.richTextBox1.AppendText("</");
                        this.richTextBox1.SelectionColor = Color.Brown;
                        this.richTextBox1.AppendText(reader.Name);
                        this.richTextBox1.SelectionColor = Color.Blue;
                        this.richTextBox1.AppendText(">");
                        this.richTextBox1.AppendText("\n");
                        break;
                }
            }
 * 
 * 
*/