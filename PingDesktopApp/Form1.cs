using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace PingDesktopApp
{
    public partial class formPing : Form
    {
        int sucessPing;
        int failedPing;

        public formPing()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            spinBox_PingInterval.Value = 2000;
            timer1.Enabled = true;
            sucessPing = 0;
            failedPing = 0;
        }

        private void btn_Ping_Click(object sender, EventArgs e)
        {
            if (!checkBox_ContiniousPing.Checked )
            {
                PingHost();
            }
        }

        private void PingHost()
        {
            string host, data;
            byte[] buffer;
            int timeout;
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            // Use the default Ttl value which is 128,
            options.Ttl = 128;
            // fragmentation behavior.
            options.DontFragment = !(chckBox_Fragment.Checked);
            // Data buffer to be transmitted.
            data = txtBox_Data.Text;
            buffer = Encoding.ASCII.GetBytes(data);
            timeout = 120;
            // Name or address of node to access
            host = txtBox_IpAdress.Text;

            PingReply reply = pingSender.Send(host, timeout, buffer, options);
            if (reply.Status == IPStatus.Success)
            {

                txtBx_PingResp.Text += (DateTime.Now + "\n");
                txtBx_PingResp.Text += ("Success Pinging : " + host + "\n");
                txtBx_PingResp.Text += ("Roundtrip Time[ms]: " + (reply.RoundtripTime).ToString() + "\n");
                txtBx_PingResp.Text += ("Time to Live: " + (reply.Options.Ttl).ToString() + "\n");
                txtBx_PingResp.Text += ("Buffer Size: " + (reply.Buffer.Length).ToString() + "\n");
                txtBx_PingResp.Text += ("\n");
                //Console.WriteLine(" Address: {0}", reply.Address.ToString());
                //Console.WriteLine(" Dont fragment: {0}", reply.Options.DontFragment);
                sucessPing += 1;
                txtBox_SucessCounter.Text = sucessPing.ToString();
            }
            else
            {
                txtBx_PingResp.Text += (DateTime.Now + "\n");
                txtBx_PingResp.Text += ("Error connecting to network address/name: " + host);
                txtBx_PingResp.Text += ("\n");
                failedPing += 1;
                txtBox_FailedCounter.Text = failedPing.ToString();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox_ContiniousPing.Checked)
            {
                PingHost();
            }
        }

        private void spinBox_PingInterval_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (int)spinBox_PingInterval.Value;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            txtBx_PingResp.SelectionStart = txtBx_PingResp.Text.Length;
            txtBx_PingResp.ScrollToCaret();
        }
    }
}
