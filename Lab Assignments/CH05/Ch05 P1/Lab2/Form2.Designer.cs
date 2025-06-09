namespace Lab2
{
    partial class Form2
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
            this.btnClick = new System.Windows.Forms.Button();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(301, 185);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Estimate";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(177, 187);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtSpeed.TabIndex = 1;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(174, 171);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(66, 13);
            this.lblSpeed.TabIndex = 5;
            this.lblSpeed.Text = "Wind Speed";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(409, 187);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 6;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(406, 171);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Category";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.btnClick);
            this.Name = "Form2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblCategory;
    }
}

