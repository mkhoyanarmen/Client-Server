namespace ServerNew
{
    partial class frmServer
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
            this.btnRunServer = new System.Windows.Forms.Button();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.txtMessageFromClient = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessageToClient = new System.Windows.Forms.TextBox();
            this.gbMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRunServer
            // 
            this.btnRunServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRunServer.Location = new System.Drawing.Point(110, 41);
            this.btnRunServer.Name = "btnRunServer";
            this.btnRunServer.Size = new System.Drawing.Size(481, 49);
            this.btnRunServer.TabIndex = 0;
            this.btnRunServer.Text = "Միացնել Սերվերը";
            this.btnRunServer.UseVisualStyleBackColor = true;
            this.btnRunServer.Click += new System.EventHandler(this.btnRunServer_Click);
            // 
            // gbMessage
            // 
            this.gbMessage.Controls.Add(this.txtMessageFromClient);
            this.gbMessage.Controls.Add(this.btnSend);
            this.gbMessage.Controls.Add(this.txtMessageToClient);
            this.gbMessage.Enabled = false;
            this.gbMessage.Location = new System.Drawing.Point(69, 137);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Size = new System.Drawing.Size(573, 265);
            this.gbMessage.TabIndex = 7;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "Գրեք ձեր հաղորդագրությունը";
            // 
            // txtMessageFromClient
            // 
            this.txtMessageFromClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMessageFromClient.Location = new System.Drawing.Point(41, 48);
            this.txtMessageFromClient.Multiline = true;
            this.txtMessageFromClient.Name = "txtMessageFromClient";
            this.txtMessageFromClient.ReadOnly = true;
            this.txtMessageFromClient.Size = new System.Drawing.Size(222, 168);
            this.txtMessageFromClient.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(447, 222);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Ուղարկել";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessageToClient
            // 
            this.txtMessageToClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMessageToClient.Location = new System.Drawing.Point(300, 48);
            this.txtMessageToClient.Multiline = true;
            this.txtMessageToClient.Name = "txtMessageToClient";
            this.txtMessageToClient.Size = new System.Drawing.Size(222, 168);
            this.txtMessageToClient.TabIndex = 3;
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 450);
            this.Controls.Add(this.gbMessage);
            this.Controls.Add(this.btnRunServer);
            this.Name = "frmServer";
            this.Text = "Server";
            this.gbMessage.ResumeLayout(false);
            this.gbMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRunServer;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.TextBox txtMessageFromClient;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessageToClient;
    }
}

