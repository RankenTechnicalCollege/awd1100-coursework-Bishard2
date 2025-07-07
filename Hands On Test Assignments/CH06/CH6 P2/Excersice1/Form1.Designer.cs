namespace Excersice1
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
            this.btnSmall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnlarge = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSmallCount = new System.Windows.Forms.Label();
            this.lblMediumCount = new System.Windows.Forms.Label();
            this.lblLargeCount = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSmall
            // 
            this.btnSmall.Location = new System.Drawing.Point(88, 81);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(37, 23);
            this.btnSmall.TabIndex = 0;
            this.btnSmall.Text = "S";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "$9.99";
            // 
            // btnMedium
            // 
            this.btnMedium.Location = new System.Drawing.Point(173, 81);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(37, 23);
            this.btnMedium.TabIndex = 2;
            this.btnMedium.Text = "M";
            this.btnMedium.UseVisualStyleBackColor = true;
            this.btnMedium.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnlarge
            // 
            this.btnlarge.Location = new System.Drawing.Point(250, 81);
            this.btnlarge.Name = "btnlarge";
            this.btnlarge.Size = new System.Drawing.Size(37, 23);
            this.btnlarge.TabIndex = 3;
            this.btnlarge.Text = "L";
            this.btnlarge.UseVisualStyleBackColor = true;
            this.btnlarge.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "$10.99";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "$11.99";
            // 
            // lblSmallCount
            // 
            this.lblSmallCount.AutoSize = true;
            this.lblSmallCount.Location = new System.Drawing.Point(91, 107);
            this.lblSmallCount.Name = "lblSmallCount";
            this.lblSmallCount.Size = new System.Drawing.Size(33, 13);
            this.lblSmallCount.TabIndex = 6;
            this.lblSmallCount.Text = "total1";
            // 
            // lblMediumCount
            // 
            this.lblMediumCount.AutoSize = true;
            this.lblMediumCount.Location = new System.Drawing.Point(177, 107);
            this.lblMediumCount.Name = "lblMediumCount";
            this.lblMediumCount.Size = new System.Drawing.Size(33, 13);
            this.lblMediumCount.TabIndex = 7;
            this.lblMediumCount.Text = "total2";
            // 
            // lblLargeCount
            // 
            this.lblLargeCount.AutoSize = true;
            this.lblLargeCount.Location = new System.Drawing.Point(254, 107);
            this.lblLargeCount.Name = "lblLargeCount";
            this.lblLargeCount.Size = new System.Drawing.Size(33, 13);
            this.lblLargeCount.TabIndex = 8;
            this.lblLargeCount.Text = "total3";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(84, 124);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(222, 173);
            this.listBox.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(137, 388);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear Order";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "What size shirts do you need?";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(81, 316);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(46, 13);
            this.lblSubtotal.TabIndex = 12;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(81, 339);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 13;
            this.lblTax.Text = "Tax";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(81, 362);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.lblLargeCount);
            this.Controls.Add(this.lblMediumCount);
            this.Controls.Add(this.lblSmallCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlarge);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSmall);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSmall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnlarge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSmallCount;
        private System.Windows.Forms.Label lblMediumCount;
        private System.Windows.Forms.Label lblLargeCount;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
    }
}

