namespace Client
{
    partial class frmClient
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
            this.btnRunChat = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessageToServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSendedMessages = new System.Windows.Forms.ListBox();
            this.backgroundWorkerClient = new System.ComponentModel.BackgroundWorker();
            this.lstTime = new System.Windows.Forms.ListBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnRunChat
            // 
            this.btnRunChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRunChat.Location = new System.Drawing.Point(107, 37);
            this.btnRunChat.Name = "btnRunChat";
            this.btnRunChat.Size = new System.Drawing.Size(434, 50);
            this.btnRunChat.TabIndex = 2;
            this.btnRunChat.Text = "Connect to the Server";
            this.btnRunChat.UseVisualStyleBackColor = true;
            this.btnRunChat.Click += new System.EventHandler(this.btnRunChat_Click);
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(380, 426);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 27);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Ուղարկել";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessageToServer
            // 
            this.txtMessageToServer.Enabled = false;
            this.txtMessageToServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMessageToServer.Location = new System.Drawing.Point(188, 390);
            this.txtMessageToServer.Multiline = true;
            this.txtMessageToServer.Name = "txtMessageToServer";
            this.txtMessageToServer.Size = new System.Drawing.Size(267, 30);
            this.txtMessageToServer.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(242, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Message section";
            // 
            // lstSendedMessages
            // 
            this.lstSendedMessages.BackColor = System.Drawing.SystemColors.Menu;
            this.lstSendedMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSendedMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstSendedMessages.FormattingEnabled = true;
            this.lstSendedMessages.HorizontalScrollbar = true;
            this.lstSendedMessages.ItemHeight = 16;
            this.lstSendedMessages.Location = new System.Drawing.Point(81, 148);
            this.lstSendedMessages.Name = "lstSendedMessages";
            this.lstSendedMessages.Size = new System.Drawing.Size(374, 226);
            this.lstSendedMessages.TabIndex = 12;
            // 
            // backgroundWorkerClient
            // 
            this.backgroundWorkerClient.WorkerSupportsCancellation = true;
            this.backgroundWorkerClient.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // lstTime
            // 
            this.lstTime.BackColor = System.Drawing.SystemColors.Menu;
            this.lstTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstTime.FormattingEnabled = true;
            this.lstTime.HorizontalScrollbar = true;
            this.lstTime.ItemHeight = 16;
            this.lstTime.Location = new System.Drawing.Point(460, 148);
            this.lstTime.Name = "lstTime";
            this.lstTime.Size = new System.Drawing.Size(107, 226);
            this.lstTime.TabIndex = 13;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerSupportsCancellation = true;
            // 
            // frmClient
            // 
            this.ClientSize = new System.Drawing.Size(659, 503);
            this.Controls.Add(this.lstTime);
            this.Controls.Add(this.lstSendedMessages);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessageToServer);
            this.Controls.Add(this.btnRunChat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRunChat;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessageToServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSendedMessages;
        private System.ComponentModel.BackgroundWorker backgroundWorkerClient;
        private System.Windows.Forms.ListBox lstTime;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

