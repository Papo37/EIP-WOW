using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sres.Net.EEIP;

namespace test_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            EEIPClient eeipClient = new EEIPClient();
            eeipClient.RegisterSession("192.168.137.10");

            eeipClient.AssemblyObject.setInstance(100, new byte[] { 0xff,0x00});
            eeipClient.UnRegisterSession();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EEIPClient eeipClient = new EEIPClient();
            eeipClient.RegisterSession("192.168.137.10");

            eeipClient.AssemblyObject.setInstance(100, new byte[] { 0x00, 0xff });
            eeipClient.UnRegisterSession();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EEIPClient eeipClient = new EEIPClient();
            eeipClient.RegisterSession("192.168.137.10");

            eeipClient.AssemblyObject.setInstance(100, new byte[] { 0x00, 0x00 });
            eeipClient.UnRegisterSession();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EEIPClient eeipClient = new EEIPClient();
            eeipClient.RegisterSession("192.168.137.10");


            eeipClient.AssemblyObject.setInstance(100, new byte[] { 0xff, 0xff });
            System.Threading.Thread.Sleep(1000);
            eeipClient.AssemblyObject.setInstance(100, new byte[] { 0x00, 0x00 });
            System.Threading.Thread.Sleep(1000);
            eeipClient.AssemblyObject.setInstance(100, new byte[] { 0xff, 0xff });
            System.Threading.Thread.Sleep(1000);
            eeipClient.AssemblyObject.setInstance(100, new byte[] { 0x00, 0x00 });
            System.Threading.Thread.Sleep(1000);
            eeipClient.AssemblyObject.setInstance(100, new byte[] { 0xff, 0xff });
            System.Threading.Thread.Sleep(1000);
            eeipClient.AssemblyObject.setInstance(100, new byte[] { 0x00, 0x00 });
            System.Threading.Thread.Sleep(1000);
            eeipClient.AssemblyObject.setInstance(100, new byte[] { 0xff, 0xff });
            System.Threading.Thread.Sleep(1000);
            eeipClient.AssemblyObject.setInstance(100, new byte[] { 0x00, 0x00 });
            System.Threading.Thread.Sleep(1000);

            eeipClient.UnRegisterSession();


        }
    }
}
