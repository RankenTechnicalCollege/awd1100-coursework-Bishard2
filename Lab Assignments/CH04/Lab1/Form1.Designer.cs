namespace Lab1
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
            this.btnKm = new System.Windows.Forms.Button();
            this.btnMiles = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKm
            // 
            this.btnKm.Location = new System.Drawing.Point(218, 216);
            this.btnKm.Name = "btnKm";
            this.btnKm.Size = new System.Drawing.Size(100, 23);
            this.btnKm.TabIndex = 0;
            this.btnKm.Text = "Convert to km";
            this.btnKm.UseVisualStyleBackColor = true;
            this.btnKm.Click += new System.EventHandler(this.btnKm_Click);
            // 
            // btnMiles
            // 
            this.btnMiles.Location = new System.Drawing.Point(376, 216);
            this.btnMiles.Name = "btnMiles";
            this.btnMiles.Size = new System.Drawing.Size(100, 23);
            this.btnMiles.TabIndex = 1;
            this.btnMiles.Text = "Convert to miles";
            this.btnMiles.UseVisualStyleBackColor = true;
            this.btnMiles.Click += new System.EventHandler(this.btnMiles_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(215, 260);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Distance in miles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Distance in kilometers";
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(218, 173);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 20);
            this.txtMiles.TabIndex = 5;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(376, 173);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(100, 20);
            this.txtKm.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnMiles);
            this.Controls.Add(this.btnKm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKm;
        private System.Windows.Forms.Button btnMiles;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.TextBox txtKm;
    }
}

