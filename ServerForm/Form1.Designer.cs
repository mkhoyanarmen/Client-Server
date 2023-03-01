namespace ServerForm
{
    partial class Form1
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
            this.lstTime = new System.Windows.Forms.ListBox();
            this.lstSendedMessages = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessageToClient = new System.Windows.Forms.TextBox();
            this.btnRunServer = new System.Windows.Forms.Button();
            this.lstClients = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorkerServer = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lstTime
            // 
            this.lstTime.BackColor = System.Drawing.SystemColors.Menu;
            this.lstTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstTime.FormattingEnabled = true;
            this.lstTime.HorizontalScrollbar = true;
            this.lstTime.ItemHeight = 16;
            this.lstTime.Location = new System.Drawing.Point(476, 300);
            this.lstTime.Name = "lstTime";
            this.lstTime.Size = new System.Drawing.Size(107, 226);
            this.lstTime.TabIndex = 19;
            // 
            // lstSendedMessages
            // 
            this.lstSendedMessages.BackColor = System.Drawing.SystemColors.Menu;
            this.lstSendedMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSendedMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstSendedMessages.FormattingEnabled = true;
            this.lstSendedMessages.HorizontalScrollbar = true;
            this.lstSendedMessages.ItemHeight = 16;
            this.lstSendedMessages.Location = new System.Drawing.Point(97, 300);
            this.lstSendedMessages.Name = "lstSendedMessages";
            this.lstSendedMessages.Size = new System.Drawing.Size(374, 226);
            this.lstSendedMessages.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(239, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Message section";
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(383, 578);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(89, 27);
            this.btnSend.TabIndex = 16;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessageToClient
            // 
            this.txtMessageToClient.Enabled = false;
            this.txtMessageToClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMessageToClient.Location = new System.Drawing.Point(204, 537);
            this.txtMessageToClient.Multiline = true;
            this.txtMessageToClient.Name = "txtMessageToClient";
            this.txtMessageToClient.Size = new System.Drawing.Size(267, 35);
            this.txtMessageToClient.TabIndex = 15;
            // 
            // btnRunServer
            // 
            this.btnRunServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRunServer.Location = new System.Drawing.Point(97, 35);
            this.btnRunServer.Name = "btnRunServer";
            this.btnRunServer.Size = new System.Drawing.Size(420, 50);
            this.btnRunServer.TabIndex = 14;
            this.btnRunServer.Text = "Run Server";
            this.btnRunServer.UseVisualStyleBackColor = true;
            this.btnRunServer.Click += new System.EventHandler(this.btnRunChat_Click);
            // 
            // lstClients
            // 
            this.lstClients.BackColor = System.Drawing.SystemColors.Menu;
            this.lstClients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstClients.FormattingEnabled = true;
            this.lstClients.HorizontalScrollbar = true;
            this.lstClients.ItemHeight = 16;
            this.lstClients.Location = new System.Drawing.Point(137, 134);
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(335, 114);
            this.lstClients.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(254, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Server users";
            // 
            // backgroundWorkerServer
            // 
            this.backgroundWorkerServer.WorkerSupportsCancellation = true;
            this.backgroundWorkerServer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerServer_DoWork);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 635);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstClients);
            this.Controls.Add(this.lstTime);
            this.Controls.Add(this.lstSendedMessages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessageToClient);
            this.Controls.Add(this.btnRunServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTime;
        private System.Windows.Forms.ListBox lstSendedMessages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessageToClient;
        private System.Windows.Forms.Button btnRunServer;
        private System.Windows.Forms.ListBox lstClients;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerServer;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

