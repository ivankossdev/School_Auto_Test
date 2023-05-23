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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OneSender
{
    public partial class Sender : Form
    {
        AutoTest.Message message = new AutoTest.Message("doors.xml");
        public Sender()
        {
            InitializeComponent();

            foreach(var item in message.points)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (backSender.IsBusy != true)
                backSender.RunWorkerAsync();
        }

        int i = 0;

        string report = string.Empty;

        private void backSender_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            foreach (string s in message.StringBuilder((int)childrenNum.Value, checkBoxBlockUser.Checked))
            {
                report = $". {AutoTest.Program.SendToSupervisor(10500, "192.168.0.204", s, false)}\n";
                worker.ReportProgress(i++);
            }
        }

        private void backSender_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            textBoxIpAddr.AppendText(e.ProgressPercentage.ToString() + report);
            if (i > 100)
            {
                i = 0;
                textBoxIpAddr.Clear();
            }
        }

        private void backSender_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            textBoxIpAddr.AppendText("Завершено");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            MessageBox.Show(selectedState);
        }
    }
}
