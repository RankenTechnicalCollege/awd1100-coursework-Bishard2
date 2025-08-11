namespace Lab4
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(292, 32);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 46);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account #";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(173, 32);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(100, 20);
            this.txtAccount.TabIndex = 2;
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(173, 58);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(100, 20);
            this.txtPin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pin #";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(170, 107);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(52, 13);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Welcome";
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(95, 220);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(178, 20);
            this.txtWithdraw.TabIndex = 7;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(95, 182);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(178, 20);
            this.txtDeposit.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Would you like to make a withdrawal?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Would you like to make a deposit?";
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(279, 182);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnDeposit.TabIndex = 10;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(279, 217);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithdraw.TabIndex = 11;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(185, 275);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(108, 23);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print Statement";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(203, 327);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWithdraw);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnLogout;
    }
}

