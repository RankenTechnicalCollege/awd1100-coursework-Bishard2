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
            this.btnEncode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEncode = new System.Windows.Forms.TextBox();
            this.txtDecode = new System.Windows.Forms.TextBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.lblShiftError = new System.Windows.Forms.Label();
            this.lblEncodeError = new System.Windows.Forms.Label();
            this.lblDecodeError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(502, 67);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 20);
            this.btnEncode.TabIndex = 0;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shift";
            // 
            // txtEncode
            // 
            this.txtEncode.Location = new System.Drawing.Point(127, 67);
            this.txtEncode.Name = "txtEncode";
            this.txtEncode.Size = new System.Drawing.Size(369, 20);
            this.txtEncode.TabIndex = 2;
            // 
            // txtDecode
            // 
            this.txtDecode.Location = new System.Drawing.Point(127, 126);
            this.txtDecode.Name = "txtDecode";
            this.txtDecode.Size = new System.Drawing.Size(369, 20);
            this.txtDecode.TabIndex = 3;
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(502, 126);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 20);
            this.btnDecode.TabIndex = 4;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(633, 89);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(83, 20);
            this.txtShift.TabIndex = 5;
            // 
            // lblShiftError
            // 
            this.lblShiftError.AutoSize = true;
            this.lblShiftError.Location = new System.Drawing.Point(630, 126);
            this.lblShiftError.Name = "lblShiftError";
            this.lblShiftError.Size = new System.Drawing.Size(50, 13);
            this.lblShiftError.TabIndex = 6;
            this.lblShiftError.Text = "ShiftError";
            // 
            // lblEncodeError
            // 
            this.lblEncodeError.AutoSize = true;
            this.lblEncodeError.Location = new System.Drawing.Point(124, 96);
            this.lblEncodeError.Name = "lblEncodeError";
            this.lblEncodeError.Size = new System.Drawing.Size(0, 13);
            this.lblEncodeError.TabIndex = 7;
            // 
            // lblDecodeError
            // 
            this.lblDecodeError.AutoSize = true;
            this.lblDecodeError.Location = new System.Drawing.Point(124, 161);
            this.lblDecodeError.Name = "lblDecodeError";
            this.lblDecodeError.Size = new System.Drawing.Size(0, 13);
            this.lblDecodeError.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDecodeError);
            this.Controls.Add(this.lblEncodeError);
            this.Controls.Add(this.lblShiftError);
            this.Controls.Add(this.txtShift);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.txtDecode);
            this.Controls.Add(this.txtEncode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEncode;
        private System.Windows.Forms.TextBox txtDecode;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.TextBox txtShift;
        private System.Windows.Forms.Label lblShiftError;
        private System.Windows.Forms.Label lblEncodeError;
        private System.Windows.Forms.Label lblDecodeError;
    }
}

