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
            this.btnDefine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDefineTerm = new System.Windows.Forms.TextBox();
            this.lblUnknownTerm = new System.Windows.Forms.Label();
            this.txtAddTerm = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDefine
            // 
            this.btnDefine.Location = new System.Drawing.Point(335, 69);
            this.btnDefine.Name = "btnDefine";
            this.btnDefine.Size = new System.Drawing.Size(75, 23);
            this.btnDefine.TabIndex = 0;
            this.btnDefine.Text = "Define";
            this.btnDefine.UseVisualStyleBackColor = true;
            this.btnDefine.Click += new System.EventHandler(this.btnDefine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "What term do you want me to define?";
            // 
            // txtDefineTerm
            // 
            this.txtDefineTerm.Location = new System.Drawing.Point(85, 71);
            this.txtDefineTerm.Name = "txtDefineTerm";
            this.txtDefineTerm.Size = new System.Drawing.Size(244, 20);
            this.txtDefineTerm.TabIndex = 2;
            // 
            // lblUnknownTerm
            // 
            this.lblUnknownTerm.AutoSize = true;
            this.lblUnknownTerm.Location = new System.Drawing.Point(82, 111);
            this.lblUnknownTerm.Name = "lblUnknownTerm";
            this.lblUnknownTerm.Size = new System.Drawing.Size(76, 13);
            this.lblUnknownTerm.TabIndex = 3;
            this.lblUnknownTerm.Text = "Unknown term";
            // 
            // txtAddTerm
            // 
            this.txtAddTerm.Location = new System.Drawing.Point(85, 137);
            this.txtAddTerm.Name = "txtAddTerm";
            this.txtAddTerm.Size = new System.Drawing.Size(244, 20);
            this.txtAddTerm.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(335, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAddTerm);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblUnknownTerm);
            this.Controls.Add(this.txtDefineTerm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDefine);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDefine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDefineTerm;
        private System.Windows.Forms.Label lblUnknownTerm;
        private System.Windows.Forms.TextBox txtAddTerm;
        private System.Windows.Forms.Button btnAdd;
    }
}

