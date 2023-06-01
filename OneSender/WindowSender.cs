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
            message.fio = "Фамилия Имя Отчество ";

            foreach (var item in message.points)
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
        string selectedState = string.Empty;

        private void backSender_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            if (checkBoxSecurity.Checked)
            {
                string mes = message.SecurityCardMessage(selectedState);
                report = $". {AutoTest.Program.SendToSupervisor(10500, "192.168.0.204", mes, false)}\n";
                worker.ReportProgress(i++);
            }
            else
            {
                if (checkBoxAllPoints.Checked)
                {
                    foreach (string s in message.AllKppMessage((int)childrenNum.Value, checkBoxBlockUser.Checked))
                    {
                        report = $". {AutoTest.Program.SendToSupervisor(10500, "192.168.0.204", s, false)}\n";
                        worker.ReportProgress(i++);
                    }
                }
                else
                {
                    foreach (string s in message.OneKppMessqge((int)childrenNum.Value, selectedState, checkBoxBlockUser.Checked))
                    {
                        report = $". {AutoTest.Program.SendToSupervisor(10500, "192.168.0.204", s, false)}\n";
                        worker.ReportProgress(i++);
                    }
                }
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
            textBoxIpAddr.AppendText("Завершено\n");
            checkBoxSecurity.Checked = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState = comboBox1.SelectedItem.ToString();
            buttonSend.Focus();
            //MessageBox.Show(selectedState);
        }

        private void checkBoxAllPoints_CheckedChanged(object sender, EventArgs e)
        {
           if (checkBoxAllPoints.Checked)
                comboBox1.Enabled = false;
           else 
                comboBox1.Enabled = true;
        }

        private void checkBoxFio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFio.Checked)
                message.fio = "Фамилия Имя Отчество ";
            else
                message.fio = string.Empty;
        }
    }
}
