﻿namespace OneSender
{
    partial class Sender
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sender));
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelIpAddress = new System.Windows.Forms.Label();
            this.textBoxIpAddr = new System.Windows.Forms.TextBox();
            this.backSender = new System.ComponentModel.BackgroundWorker();
            this.checkBoxBlockUser = new System.Windows.Forms.CheckBox();
            this.childrenNum = new System.Windows.Forms.NumericUpDown();
            this.boxSittings = new System.Windows.Forms.GroupBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBoxAllPoints = new System.Windows.Forms.CheckBox();
            this.senderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.childrenNum)).BeginInit();
            this.boxSittings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.senderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(616, 138);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelIpAddress
            // 
            this.labelIpAddress.AutoSize = true;
            this.labelIpAddress.Location = new System.Drawing.Point(13, 13);
            this.labelIpAddress.Name = "labelIpAddress";
            this.labelIpAddress.Size = new System.Drawing.Size(123, 13);
            this.labelIpAddress.TabIndex = 1;
            this.labelIpAddress.Text = "Отправленные данные";
            // 
            // textBoxIpAddr
            // 
            this.textBoxIpAddr.Location = new System.Drawing.Point(12, 29);
            this.textBoxIpAddr.Multiline = true;
            this.textBoxIpAddr.Name = "textBoxIpAddr";
            this.textBoxIpAddr.ReadOnly = true;
            this.textBoxIpAddr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIpAddr.Size = new System.Drawing.Size(679, 103);
            this.textBoxIpAddr.TabIndex = 2;
            // 
            // backSender
            // 
            this.backSender.WorkerReportsProgress = true;
            this.backSender.WorkerSupportsCancellation = true;
            this.backSender.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backSender_DoWork);
            this.backSender.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backSender_ProgressChanged);
            this.backSender.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backSender_RunWorkerCompleted);
            // 
            // checkBoxBlockUser
            // 
            this.checkBoxBlockUser.AutoSize = true;
            this.checkBoxBlockUser.Location = new System.Drawing.Point(8, 19);
            this.checkBoxBlockUser.Name = "checkBoxBlockUser";
            this.checkBoxBlockUser.Size = new System.Drawing.Size(99, 17);
            this.checkBoxBlockUser.TabIndex = 3;
            this.checkBoxBlockUser.Text = "Заблокирован";
            this.checkBoxBlockUser.UseVisualStyleBackColor = true;
            // 
            // childrenNum
            // 
            this.childrenNum.Location = new System.Drawing.Point(8, 42);
            this.childrenNum.Name = "childrenNum";
            this.childrenNum.Size = new System.Drawing.Size(50, 20);
            this.childrenNum.TabIndex = 4;
            this.childrenNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // boxSittings
            // 
            this.boxSittings.Controls.Add(this.checkBoxAllPoints);
            this.boxSittings.Controls.Add(this.comboBox1);
            this.boxSittings.Controls.Add(this.labelUser);
            this.boxSittings.Controls.Add(this.checkBoxBlockUser);
            this.boxSittings.Controls.Add(this.childrenNum);
            this.boxSittings.Location = new System.Drawing.Point(12, 138);
            this.boxSittings.Name = "boxSittings";
            this.boxSittings.Size = new System.Drawing.Size(365, 74);
            this.boxSittings.TabIndex = 5;
            this.boxSittings.TabStop = false;
            this.boxSittings.Text = "Настройки";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(57, 44);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(50, 13);
            this.labelUser.TabIndex = 5;
            this.labelUser.Text = "Ученики";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "КПП";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBoxAllPoints
            // 
            this.checkBoxAllPoints.AutoSize = true;
            this.checkBoxAllPoints.Checked = true;
            this.checkBoxAllPoints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAllPoints.Location = new System.Drawing.Point(113, 19);
            this.checkBoxAllPoints.Name = "checkBoxAllPoints";
            this.checkBoxAllPoints.Size = new System.Drawing.Size(103, 17);
            this.checkBoxAllPoints.TabIndex = 7;
            this.checkBoxAllPoints.Text = "Все проходные";
            this.checkBoxAllPoints.UseVisualStyleBackColor = true;
            this.checkBoxAllPoints.CheckedChanged += new System.EventHandler(this.checkBoxAllPoints_CheckedChanged);
            // 
            // senderBindingSource
            // 
            this.senderBindingSource.DataSource = typeof(OneSender.Sender);
            // 
            // Sender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 224);
            this.Controls.Add(this.boxSittings);
            this.Controls.Add(this.textBoxIpAddr);
            this.Controls.Add(this.labelIpAddress);
            this.Controls.Add(this.buttonSend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sender";
            ((System.ComponentModel.ISupportInitialize)(this.childrenNum)).EndInit();
            this.boxSittings.ResumeLayout(false);
            this.boxSittings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.senderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelIpAddress;
        private System.Windows.Forms.TextBox textBoxIpAddr;
        private System.ComponentModel.BackgroundWorker backSender;
        private System.Windows.Forms.CheckBox checkBoxBlockUser;
        private System.Windows.Forms.NumericUpDown childrenNum;
        private System.Windows.Forms.GroupBox boxSittings;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource senderBindingSource;
        private System.Windows.Forms.CheckBox checkBoxAllPoints;
    }
}

