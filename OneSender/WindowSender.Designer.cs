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
            this.childrenNum = new System.Windows.Forms.NumericUpDown();
            this.boxSittings = new System.Windows.Forms.GroupBox();
            this.buttonChildren = new System.Windows.Forms.Button();
            this.buttonParent = new System.Windows.Forms.Button();
            this.checkBoxGroup = new System.Windows.Forms.CheckBox();
            this.checkBoxSecurity = new System.Windows.Forms.CheckBox();
            this.checkBoxFio = new System.Windows.Forms.CheckBox();
            this.checkBoxAllPoints = new System.Windows.Forms.CheckBox();
            this.comboBoxPoints = new System.Windows.Forms.ComboBox();
            this.labelUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.childrenNum)).BeginInit();
            this.boxSittings.SuspendLayout();
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
            this.boxSittings.Controls.Add(this.buttonChildren);
            this.boxSittings.Controls.Add(this.buttonParent);
            this.boxSittings.Controls.Add(this.checkBoxGroup);
            this.boxSittings.Controls.Add(this.checkBoxSecurity);
            this.boxSittings.Controls.Add(this.checkBoxFio);
            this.boxSittings.Controls.Add(this.checkBoxAllPoints);
            this.boxSittings.Controls.Add(this.comboBoxPoints);
            this.boxSittings.Controls.Add(this.labelUser);
            this.boxSittings.Controls.Add(this.checkBoxBlockUser);
            this.boxSittings.Controls.Add(this.childrenNum);
            this.boxSittings.Location = new System.Drawing.Point(12, 138);
            this.boxSittings.Name = "boxSittings";
            this.boxSittings.Size = new System.Drawing.Size(598, 74);
            this.boxSittings.TabIndex = 5;
            this.boxSittings.TabStop = false;
            this.boxSittings.Text = "Настройки";
            // 
            // buttonChildren
            // 
            this.buttonChildren.Enabled = false;
            this.buttonChildren.Location = new System.Drawing.Point(421, 39);
            this.buttonChildren.Name = "buttonChildren";
            this.buttonChildren.Size = new System.Drawing.Size(75, 23);
            this.buttonChildren.TabIndex = 12;
            this.buttonChildren.Text = "Ученик";
            this.buttonChildren.UseVisualStyleBackColor = true;
            this.buttonChildren.Click += new System.EventHandler(this.buttonChildren_Click);
            // 
            // buttonParent
            // 
            this.buttonParent.Enabled = false;
            this.buttonParent.Location = new System.Drawing.Point(340, 39);
            this.buttonParent.Name = "buttonParent";
            this.buttonParent.Size = new System.Drawing.Size(75, 23);
            this.buttonParent.TabIndex = 11;
            this.buttonParent.Text = "Родитель";
            this.buttonParent.UseVisualStyleBackColor = true;
            this.buttonParent.Click += new System.EventHandler(this.buttonParent_Click);
            // 
            // checkBoxGroup
            // 
            this.checkBoxGroup.AutoSize = true;
            this.checkBoxGroup.Enabled = false;
            this.checkBoxGroup.Location = new System.Drawing.Point(340, 19);
            this.checkBoxGroup.Name = "checkBoxGroup";
            this.checkBoxGroup.Size = new System.Drawing.Size(61, 17);
            this.checkBoxGroup.TabIndex = 10;
            this.checkBoxGroup.Text = "Группа";
            this.checkBoxGroup.UseVisualStyleBackColor = true;
            this.checkBoxGroup.CheckedChanged += new System.EventHandler(this.checkBoxGroup_CheckedChanged);
            // 
            // checkBoxSecurity
            // 
            this.checkBoxSecurity.AutoSize = true;
            this.checkBoxSecurity.Location = new System.Drawing.Point(243, 43);
            this.checkBoxSecurity.Name = "checkBoxSecurity";
            this.checkBoxSecurity.Size = new System.Drawing.Size(98, 17);
            this.checkBoxSecurity.TabIndex = 9;
            this.checkBoxSecurity.Text = "Карта Охраны";
            this.checkBoxSecurity.UseVisualStyleBackColor = true;
            // 
            // checkBoxFio
            // 
            this.checkBoxFio.AutoSize = true;
            this.checkBoxFio.Checked = true;
            this.checkBoxFio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFio.Location = new System.Drawing.Point(243, 20);
            this.checkBoxFio.Name = "checkBoxFio";
            this.checkBoxFio.Size = new System.Drawing.Size(62, 17);
            this.checkBoxFio.TabIndex = 8;
            this.checkBoxFio.Text = "Ф.И.О.";
            this.checkBoxFio.UseVisualStyleBackColor = true;
            this.checkBoxFio.CheckedChanged += new System.EventHandler(this.checkBoxFio_CheckedChanged);
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
            // comboBoxPoints
            // 
            this.comboBoxPoints.Enabled = false;
            this.comboBoxPoints.FormattingEnabled = true;
            this.comboBoxPoints.Location = new System.Drawing.Point(113, 41);
            this.comboBoxPoints.Name = "comboBoxPoints";
            this.comboBoxPoints.Size = new System.Drawing.Size(124, 21);
            this.comboBoxPoints.TabIndex = 6;
            this.comboBoxPoints.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(719, 263);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(719, 263);
            this.Name = "Sender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supervisor Tester";
            ((System.ComponentModel.ISupportInitialize)(this.childrenNum)).EndInit();
            this.boxSittings.ResumeLayout(false);
            this.boxSittings.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBoxPoints;
        private System.Windows.Forms.CheckBox checkBoxAllPoints;
        private System.Windows.Forms.CheckBox checkBoxFio;
        private System.Windows.Forms.CheckBox checkBoxSecurity;
        private System.Windows.Forms.CheckBox checkBoxGroup;
        private System.Windows.Forms.Button buttonChildren;
        private System.Windows.Forms.Button buttonParent;
    }
}

