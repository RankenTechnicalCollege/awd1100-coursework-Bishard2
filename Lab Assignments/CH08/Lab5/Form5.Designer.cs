namespace Lab5
{
    partial class Form5
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
            this.btnMask = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMask
            // 
            this.btnMask.Location = new System.Drawing.Point(245, 89);
            this.btnMask.Name = "btnMask";
            this.btnMask.Size = new System.Drawing.Size(75, 23);
            this.btnMask.TabIndex = 0;
            this.btnMask.Text = "Mask";
            this.btnMask.UseVisualStyleBackColor = true;
            this.btnMask.Click += new System.EventHandler(this.btnMask_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(73, 139);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 13);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Masked";
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(76, 89);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(163, 20);
            this.txtCC.TabIndex = 2;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnMask);
            this.Name = "Form5";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMask;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtCC;
    }
}

