namespace OneSender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sender));
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelIpAddress = new System.Windows.Forms.Label();
            this.textBoxIpAddr = new System.Windows.Forms.TextBox();
            this.backSender = new System.ComponentModel.BackgroundWorker();
            this.checkBoxBlockUser = new System.Windows.Forms.CheckBox();
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
            this.checkBoxBlockUser.Location = new System.Drawing.Point(12, 144);
            this.checkBoxBlockUser.Name = "checkBoxBlockUser";
            this.checkBoxBlockUser.Size = new System.Drawing.Size(99, 17);
            this.checkBoxBlockUser.TabIndex = 3;
            this.checkBoxBlockUser.Text = "Заблокирован";
            this.checkBoxBlockUser.UseVisualStyleBackColor = true;
            // 
            // Sender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 173);
            this.Controls.Add(this.checkBoxBlockUser);
            this.Controls.Add(this.textBoxIpAddr);
            this.Controls.Add(this.labelIpAddress);
            this.Controls.Add(this.buttonSend);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelIpAddress;
        private System.Windows.Forms.TextBox textBoxIpAddr;
        private System.ComponentModel.BackgroundWorker backSender;
        private System.Windows.Forms.CheckBox checkBoxBlockUser;
    }
}

