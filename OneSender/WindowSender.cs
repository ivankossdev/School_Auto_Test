using AutoTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneSender
{
    public partial class Sender : Form
    {
        AutoTest.Message message = new AutoTest.Message("doors.xml");
        public Sender()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            new Thread(() => Send(message, textBoxIpAddr.Text)).Start();  
        }

        private void Send(AutoTest.Message message, string ip)
        {
            foreach (string s in message.StringBuilder(4))
            {
                AutoTest.Program.SendToSupervisor(10500, ip.Trim(), s, false);
            }
        }
    }
}
