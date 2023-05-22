﻿using AutoTest;
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
            if (backSender.IsBusy != true)
                backSender.RunWorkerAsync();
        }

        int i = 0;

        string report = string.Empty;

        private void backSender_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            foreach (string s in message.StringBuilder(4, checkBoxBlockUser.Checked))
            {
                report = $" {AutoTest.Program.SendToSupervisor(10500, "192.168.0.204", s, false)}\n";
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
    }
}
