using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace EmailSender
{
    public partial class FrmDebug : Form
    {
        public FrmDebug(Exception ex)
        {
            InitializeComponent();
            _ex = ex;
            this.Closing += new CancelEventHandler(FrmDebug_Closing);
        }

        void FrmDebug_Closing(object sender, CancelEventArgs e)
        {
            if (this.uxCloseApp.Checked)
                this.DialogResult = DialogResult.Abort;
        }

        private Exception _ex;
        private void FrmDebug_Load(object sender, EventArgs e)
        {
            uxReportText.Text += _ex.ToString() + "\n\n";
            uxReportText.Text += "ProductName:" + Application.ProductName.ToString() + "\n\n";
            uxReportText.Text += "ProductVersion:" + Application.ProductVersion.ToString() + "\n\n";
            uxReportText.Text += "ExecutablePath:" + Application.ExecutablePath.ToString() + "\n\n";
            uxReportText.Text += "StartupPath:" + Application.StartupPath.ToString() + "\n\n";
            uxReportText.Text += "Culture:" + Application.CurrentCulture.ToString() + "\n\n";
            uxReportText.Text += "OS:" + OS_Version() + "\n\n";
            uxReportText.Text += "OS Version:" + System.Environment.OSVersion.ToString() + "\n";
        }

        private void uxSendReport_Click(object sender, EventArgs e)
        {
            this.uxSendReport.Enabled = false;
            try
            {
                // Create a request for the URL. 
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.faena.com/erp/errreport.php");
                // If required by the server, set the credentials.
                request.Credentials = CredentialCache.DefaultCredentials;
                // Create a new string object to POST data to the Url.
                string inputData = this.uxReportText.Text;
                string postData = "report" + (char)0x3D + inputData;
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] byte1 = encoding.GetBytes(postData);
                // Set the content type of the data being posted.
                request.Method = "POST";
                request.UserAgent = Application.ProductName; // "Faena MRP"
                request.ContentType = "application/x-www-form-urlencoded";
                // Set the content length of the string being posted.
                request.ContentLength = postData.Length;
                Stream newStream = request.GetRequestStream();
                newStream.Write(byte1, 0, byte1.Length);
                //Console.WriteLine("The value of 'ContentLength' property after sending the data is {0}", HttpWReq.ContentLength)
                newStream.Close();

                HttpWebResponse response = (HttpWebResponse)(request.GetResponse());
                // Display the status.
                Console.WriteLine(response.StatusDescription);
                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                Console.WriteLine(responseFromServer);
                // Cleanup the streams and the response.
                reader.Close();
                dataStream.Close();
                response.Close();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not send Problem Report via the Internet.\n" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.uxSendReport.Enabled = true;
        }

        private string OS_Version()
        {
            OperatingSystem osInfo;
            string sAns = "";

            osInfo = System.Environment.OSVersion;

            switch (osInfo.Platform)
            {
                case PlatformID.Win32Windows:
                    switch (osInfo.Version.Minor)
                    {
                        case 0:
                            sAns = "Windows 95";
                            break;
                        case 10:
                            if (osInfo.Version.Revision.ToString() == "2222A")
                                sAns = "Windows 98 Second Edition";
                            else
                                sAns = "Windows 98";
                            break;
                        case 90:
                            sAns = "Windows Me";
                            break;
                    }
                    break;
                case PlatformID.Win32NT:
                    switch (osInfo.Version.Major)
                    {
                        case 3:
                            sAns = "Windows NT 3.51";
                            break;
                        case 4:
                            sAns = "Windows NT 4.0";
                            break;
                        case 5:
                            if (osInfo.Version.Minor == 0)
                                sAns = "Windows 2000";
                            else if (osInfo.Version.Minor == 1)
                                sAns = "Windows XP";
                            else if (osInfo.Version.Minor == 2)
                                sAns = "Windows Server 2003";
                            else //'Future version maybe update as needed
                                sAns = "Unknown Windows Version";
                            break;
                    }
                    break;
            }
            return sAns;
        }
    }
}