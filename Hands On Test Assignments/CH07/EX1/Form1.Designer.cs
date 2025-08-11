namespace EX1
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(91, 81);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter a test score";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(91, 55);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(121, 20);
            this.txtScore.TabIndex = 2;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(88, 150);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(44, 13);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "Number";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(88, 172);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(28, 13);
            this.lblSum.TabIndex = 4;
            this.lblSum.Text = "Sum";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(88, 195);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(47, 13);
            this.lblAverage.TabIndex = 5;
            this.lblAverage.Text = "Average";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(88, 218);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(41, 13);
            this.lblMin.TabIndex = 6;
            this.lblMin.Text = "Lowest";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(88, 242);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(43, 13);
            this.lblMax.TabIndex = 7;
            this.lblMax.Text = "Highest";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(88, 117);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(29, 13);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "Error";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblError;
    }
}

