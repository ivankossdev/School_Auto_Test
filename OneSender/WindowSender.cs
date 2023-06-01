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
        MessageGenerate message = new MessageGenerate("doors.xml");
        XmlHandler getIp = new XmlHandler();
        string ip = string.Empty;

        public Sender()
        {
            InitializeComponent(); 

            List<string> ipAddr = getIp.GetElemets("doors.xml", "ip");
            if (ipAddr.Count > 0)
            {
                ip = ipAddr[0];
            }

            message.fio = "Фамилия Имя Отчество ";

            foreach (var item in message.points)
            {
                comboBoxPoints.Items.Add(item);
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
                report = $". {AutoTest.Program.SendToSupervisor(10500, ip, mes, false)}\n";
                worker.ReportProgress(i++);
            }
            else
            {
                if (checkBoxAllPoints.Checked)
                {
                    foreach (string s in message.AllKppMessage((int)childrenNum.Value, checkBoxBlockUser.Checked))
                    {
                        report = $". {AutoTest.Program.SendToSupervisor(10500, ip, s, false)}\n";
                        worker.ReportProgress(i++);
                    }
                }
                else
                {
                    foreach (string s in message.OneKppMessqge((int)childrenNum.Value, selectedState, checkBoxBlockUser.Checked))
                    {
                        report = $". {AutoTest.Program.SendToSupervisor(10500, ip, s, false)}\n";
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
            if (checkBoxSecurity.Checked) checkBoxSecurity.Checked = false;
             
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedState = comboBoxPoints.SelectedItem.ToString();
            buttonSend.Focus();
            //MessageBox.Show(selectedState);
        }

        private void checkBoxAllPoints_CheckedChanged(object sender, EventArgs e)
        {
           if (checkBoxAllPoints.Checked) 
                comboBoxPoints.Enabled = false;
           else
            {
                comboBoxPoints.Enabled = true;
                checkBoxFio.Checked = false;
            }
                
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
