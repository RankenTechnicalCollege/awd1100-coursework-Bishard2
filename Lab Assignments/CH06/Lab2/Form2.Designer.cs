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
            this.btnAdmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.txtTestScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdmit
            // 
            this.btnAdmit.Location = new System.Drawing.Point(93, 156);
            this.btnAdmit.Name = "btnAdmit";
            this.btnAdmit.Size = new System.Drawing.Size(75, 23);
            this.btnAdmit.TabIndex = 0;
            this.btnAdmit.Text = "Admit";
            this.btnAdmit.UseVisualStyleBackColor = true;
            this.btnAdmit.Click += new System.EventHandler(this.btnAdmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "GPA";
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(93, 130);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(100, 20);
            this.txtGPA.TabIndex = 2;
            this.txtGPA.TextChanged += new System.EventHandler(this.txtGPA_TextChanged);
            // 
            // txtTestScore
            // 
            this.txtTestScore.Location = new System.Drawing.Point(214, 130);
            this.txtTestScore.Name = "txtTestScore";
            this.txtTestScore.Size = new System.Drawing.Size(100, 20);
            this.txtTestScore.TabIndex = 3;
            this.txtTestScore.TextChanged += new System.EventHandler(this.txtAdTestScore_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Admission Test Score";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(186, 161);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(42, 13);
            this.lblResults.TabIndex = 5;
            this.lblResults.Text = "Results";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTestScore);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdmit);
            this.Name = "Form2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.TextBox txtTestScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResults;
    }
}

