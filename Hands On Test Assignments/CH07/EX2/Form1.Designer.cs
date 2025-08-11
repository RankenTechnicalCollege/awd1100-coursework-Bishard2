namespace EX2
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
            this.btnArithmetic = new System.Windows.Forms.Button();
            this.btnFormat = new System.Windows.Forms.Button();
            this.btnNull = new System.Windows.Forms.Button();
            this.btnInvalid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArithmetic
            // 
            this.btnArithmetic.Location = new System.Drawing.Point(25, 12);
            this.btnArithmetic.Name = "btnArithmetic";
            this.btnArithmetic.Size = new System.Drawing.Size(370, 203);
            this.btnArithmetic.TabIndex = 0;
            this.btnArithmetic.Text = "System.ArithmeticException";
            this.btnArithmetic.UseVisualStyleBackColor = true;
            this.btnArithmetic.Click += new System.EventHandler(this.btnArithmetic_Click);
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(401, 12);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(387, 203);
            this.btnFormat.TabIndex = 1;
            this.btnFormat.Text = "System.FormatException";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // btnNull
            // 
            this.btnNull.Location = new System.Drawing.Point(401, 221);
            this.btnNull.Name = "btnNull";
            this.btnNull.Size = new System.Drawing.Size(387, 217);
            this.btnNull.TabIndex = 3;
            this.btnNull.Text = "System.NullReferenceException";
            this.btnNull.UseVisualStyleBackColor = true;
            this.btnNull.Click += new System.EventHandler(this.btnNull_Click);
            // 
            // btnInvalid
            // 
            this.btnInvalid.Location = new System.Drawing.Point(25, 221);
            this.btnInvalid.Name = "btnInvalid";
            this.btnInvalid.Size = new System.Drawing.Size(370, 217);
            this.btnInvalid.TabIndex = 2;
            this.btnInvalid.Text = "System.InvalidCastException";
            this.btnInvalid.UseVisualStyleBackColor = true;
            this.btnInvalid.Click += new System.EventHandler(this.btnInvalid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNull);
            this.Controls.Add(this.btnInvalid);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.btnArithmetic);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArithmetic;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.Button btnNull;
        private System.Windows.Forms.Button btnInvalid;
    }
}

