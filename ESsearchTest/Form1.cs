using Nest;
using System;
using System.Windows.Forms;

namespace ESsearchTest
{
    public partial class Form1 : Form
    {
        ConnectionSettings connectionSettings;
        ElasticClient elasticClient;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            URITextBox.Text = Properties.Settings.Default.URI;
            AuthCheckBox.Checked = Properties.Settings.Default.Auth;
            UserTextBox.Text = Properties.Settings.Default.Username;
            PasswordTextBox.Text = Properties.Settings.Default.Password;

            connect();
        }

        private void connect()
        {
            //Establishing connection with ES
            connectionSettings = new ConnectionSettings(new Uri(URITextBox.Text)); //local PC            
            if (AuthCheckBox.Checked)
                connectionSettings.BasicAuthentication(UserTextBox.Text, PasswordTextBox.Text);
            elasticClient = new ElasticClient(connectionSettings);
        }

        //Retrieve information based on search textbox value
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Search query to retrieve info
            DateTime startTime = DateTime.Now;
            var response = elasticClient.Search<hybrid>(s => s
                .Index("hybrid")
                .Type("address")
                .Query(q => q.QueryString(qs => qs.Query(tbxName.Text + "*"))));
            DateTime endTime = DateTime.Now;
            TimeSpan duration = endTime - startTime;


            if (rtxSearchResult.Text != " ")
            {
                rtxSearchResult.Clear();
                rtxSearchResult.AppendText("Duration: " + duration.TotalMilliseconds + "ms" + Environment.NewLine + Environment.NewLine);
                foreach (var hit in response.Hits)
                {
                    if (hit.Source.paf.Count > 0)
                        if (hit.Source.uprn != null && hit.Source.paf[0].buildingNumber != null && hit.Source.paf[0].thoroughfare != null && hit.Source.paf[0].postTown != null && hit.Source.paf[0].postcode != null)
                            rtxSearchResult.AppendText("UPRN:        " + hit.Source.uprn
                            + Environment.NewLine
                            + "Building No:        " + hit.Source.paf[0].buildingNumber
                            + Environment.NewLine
                            + "StreeName:        " + hit.Source.paf[0].thoroughfare
                            + Environment.NewLine
                            + "Post Town:        " + hit.Source.paf[0].postTown
                            + Environment.NewLine
                            + "Post Code:        " + hit.Source.paf[0].postcode
                            + Environment.NewLine + Environment.NewLine);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save Settings
            Properties.Settings.Default.URI = this.URITextBox.Text;
            Properties.Settings.Default.Auth = this.AuthCheckBox.Checked;
            Properties.Settings.Default.Username = this.UserTextBox.Text;
            Properties.Settings.Default.Password = this.PasswordTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void some_TextChanged(object sender, EventArgs e)
        {
            connect();
        }
    }
}

