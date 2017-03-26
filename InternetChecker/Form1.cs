using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace InternetChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ping p = new Ping();
            PingReply result = p.Send("8.8.8.8");
            if(result.Status.ToString()=="Success")
            {
                //MessageBox.Show("Status :  " + result.Status + " \n Time : " + result.RoundtripTime.ToString() + " \n Address : " + result.Address);
                //MessageBox.Show("Internet is working");
                lblWorking.Visible = true;
                lblNotWorking.Visible = false;

            }
            else
            {
               // MessageBox.Show("Internet is not working");
                lblNotWorking.Visible = true;
                lblWorking.Visible = false;
            }

        }
    }
}
