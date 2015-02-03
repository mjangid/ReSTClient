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
        public FrmMain()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;

            MoveControls();
        }

        void FillResponseHeader(HttpResponseHeaders headers)
        {
            //empty the grid
            int nCount = dataGridViewHeader.Rows.Count();
           
            //fill the grid from response
            int nRows = 0;
            var enum1 = headers.GetEnumerator();
            while (enum1.MoveNext())
            {
                KeyValuePair<string, IEnumerable<string>> kvPair = enum1.Current;
                dataGridViewHeader.Rows.Add();
                dataGridViewHeader.Rows[nRows].Cells[0].Value = kvPair.Key;
                var enum2 = headers.GetValues(kvPair.Key).GetEnumerator();
                while (enum2.MoveNext())
                {
                    dataGridViewHeader.Rows[nRows++].Cells[1].Value = enum2.Current;
                }
            }            
        }
        void MoveControls()
        {
            // tab control position
            tabControl1.Top = 50;
            tabControl1.Left = 5;
            tabControl1.Width = this.Width - 20;
            tabControl1.Height = this.Height - 60;

            rtbResponse.Top = 5;
            rtbResponse.Left = 5;
            rtbResponse.Width = tabControl1.Width - 40;
            rtbResponse.Height = tabControl1.Height - 70;

            dataGridViewHeader.Top = 5;
            dataGridViewHeader.Left = 5;
            dataGridViewHeader.Width = tabControl1.Width - 40; ;
            dataGridViewHeader.Height = tabControl1.Height - 70;

            comboBox1.Left = 5;
            comboBox1.Top = 5;
            comboBox1.Height = 40;
            comboBox1.Width = 95;

            txtURI.Left = 105;
            txtURI.Top = 5;
            txtURI.Height = 40;
            txtURI.Width = this.Width - 200;

            button1.Left = this.Width - 85;
            button1.Top = 5;
            button1.Height = 40;
            button1.Width = 60;

            listHistory.Top = 5;
            listHistory.Left = 5;
            listHistory.Width = this.Width - 40;
            listHistory.Height = tabControl1.Height - 70;

        }
        private void OnSize(object sender, EventArgs e)
        {
            MoveControls();
        }

        private void OnSend(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: //GET
                    getRequest();
                    break;
                case 1: //PUT
                    putRequest();
                    break;
                case 2: //POST
                    postRequest();
                    break;
                case 3: //DELETE
                    deleteRequest();
                    break;
                case 4: //INTERNET Mode
                    internetRequest();
                    return;
            }
            tabControl1.SelectedIndex = 0;
        }

        private void SetLink(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel link = (LinkLabel) sender;
            txtURI.Text = link.Text;
        }

        private async void getRequest()
        {
            try
            {
                string responseBodyAsText;
                string url_string = txtURI.Text;
                HttpClient httpClient = new HttpClient();

                var byteArray = Encoding.ASCII.GetBytes(txtUserName.Text + ":" + txtPassword.Text);
                var header = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                httpClient.DefaultRequestHeaders.Authorization = header;

                HttpResponseMessage response = await httpClient.GetAsync(url_string);
                response.EnsureSuccessStatusCode();
                responseBodyAsText = await response.Content.ReadAsStringAsync();
//              responseBodyAsText = responseBodyAsText.Replace("<br>", Environment.NewLine); // Insert new lines
                rtbResponse.Text = responseBodyAsText;
                xmlView.Navigate(url_string);

                // fill response headers
                FillResponseHeader(response.Headers);
            }
            catch (HttpRequestException hre)
            {
                rtbResponse.Text = hre.ToString();
            }
            catch (Exception ex)
            {
                rtbResponse.Text = ex.ToString();
            }
        }
        private async void putRequest()
        {
            try{
                string responseBodyAsText;
                string url_string = txtURI.Text;
                HttpClient httpClient = new HttpClient();
                HttpContent httpContent = new StringContent(rtbRequest.Rtf);

                var byteArray = Encoding.ASCII.GetBytes(txtUserName.Text + ":" + txtPassword.Text);
                var header = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                httpClient.DefaultRequestHeaders.Authorization = header;

                HttpResponseMessage response = await httpClient.PutAsync(url_string, httpContent);
                response.EnsureSuccessStatusCode();
                responseBodyAsText = await response.Content.ReadAsStringAsync();
                rtbResponse.Text = responseBodyAsText;
                xmlView.Navigate(url_string);

            }
            catch (HttpRequestException hre)
            {
                rtbResponse.Text = hre.ToString();
            }
            catch (Exception ex)
            {
                rtbResponse.Text = ex.ToString();
            }

        }
        private async void postRequest()
        {
            try
            {
                string responseBodyAsText;
                string url_string = txtURI.Text;
                HttpClient httpClient = new HttpClient();
                HttpContent httpContent = new StringContent(rtbRequest.Rtf);

                var byteArray = Encoding.ASCII.GetBytes(txtUserName.Text + ":" + txtPassword.Text);
                var header = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                httpClient.DefaultRequestHeaders.Authorization = header;

                HttpResponseMessage response = await httpClient.PostAsync(url_string, httpContent);
                response.EnsureSuccessStatusCode();
                responseBodyAsText = await response.Content.ReadAsStringAsync();
                //                responseBodyAsText = responseBodyAsText.Replace("<br>", Environment.NewLine); // Insert new lines
                rtbResponse.Text = responseBodyAsText;
                xmlView.Navigate(url_string);

            }
            catch (HttpRequestException hre)
            {
                rtbResponse.Text = hre.ToString();
            }
            catch (Exception ex)
            {
                rtbResponse.Text = ex.ToString();
            }

        }
        private async void deleteRequest()
        {
            try
            {
                string responseBodyAsText;
                string url_string = txtURI.Text;
                HttpClient httpClient = new HttpClient();

                var byteArray = Encoding.ASCII.GetBytes(txtUserName.Text + ":" + txtPassword.Text);
                var header = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
                httpClient.DefaultRequestHeaders.Authorization = header;

                HttpResponseMessage response = await httpClient.DeleteAsync(url_string);
                response.EnsureSuccessStatusCode();
                responseBodyAsText = await response.Content.ReadAsStringAsync();
                //        responseBodyAsText = responseBodyAsText.Replace("<br>", Environment.NewLine); // Insert new lines
                rtbResponse.Text = responseBodyAsText;
                xmlView.Navigate(url_string);

            }
            catch (HttpRequestException hre)
            {
                rtbResponse.Text = hre.ToString();
            }
            catch (Exception ex)
            {
                rtbResponse.Text = ex.ToString();
            }

        }
        private void internetRequest()
        {
            tabControl1.SelectedIndex = 2;
            xmlView.Navigate(txtURI.Text);
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