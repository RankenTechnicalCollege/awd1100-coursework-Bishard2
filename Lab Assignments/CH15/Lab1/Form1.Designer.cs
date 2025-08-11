namespace CH14_15
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecipient = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTrackingNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(193, 169);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recipient";
            // 
            // txtRecipient
            // 
            this.txtRecipient.Location = new System.Drawing.Point(222, 58);
            this.txtRecipient.Name = "txtRecipient";
            this.txtRecipient.Size = new System.Drawing.Size(100, 20);
            this.txtRecipient.TabIndex = 2;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(222, 84);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 3;
            // 
            // txtTrackingNumber
            // 
            this.txtTrackingNumber.Location = new System.Drawing.Point(222, 110);
            this.txtTrackingNumber.Name = "txtTrackingNumber";
            this.txtTrackingNumber.Size = new System.Drawing.Size(100, 20);
            this.txtTrackingNumber.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sent Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tracking Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "(Additional Fee for certified letter)";
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(362, 58);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(255, 199);
            this.lstLog.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTrackingNumber);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtRecipient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecipient;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtTrackingNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstLog;
    }
}

