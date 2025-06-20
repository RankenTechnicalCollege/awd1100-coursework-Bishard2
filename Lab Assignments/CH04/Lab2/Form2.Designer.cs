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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEgg1 = new System.Windows.Forms.TextBox();
            this.txtEgg2 = new System.Windows.Forms.TextBox();
            this.txtEgg3 = new System.Windows.Forms.TextBox();
            this.txtEgg4 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(319, 167);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter number of eggs laid by each chicken";
            // 
            // txtEgg1
            // 
            this.txtEgg1.Location = new System.Drawing.Point(130, 113);
            this.txtEgg1.Name = "txtEgg1";
            this.txtEgg1.Size = new System.Drawing.Size(100, 20);
            this.txtEgg1.TabIndex = 2;
            this.txtEgg1.TextChanged += new System.EventHandler(this.txtBox1_TextChanged);
            // 
            // txtEgg2
            // 
            this.txtEgg2.Location = new System.Drawing.Point(257, 113);
            this.txtEgg2.Name = "txtEgg2";
            this.txtEgg2.Size = new System.Drawing.Size(100, 20);
            this.txtEgg2.TabIndex = 3;
            this.txtEgg2.TextChanged += new System.EventHandler(this.txtBox2_TextChanged);
            // 
            // txtEgg3
            // 
            this.txtEgg3.Location = new System.Drawing.Point(370, 113);
            this.txtEgg3.Name = "txtEgg3";
            this.txtEgg3.Size = new System.Drawing.Size(100, 20);
            this.txtEgg3.TabIndex = 4;
            this.txtEgg3.TextChanged += new System.EventHandler(this.txtBox3_TextChanged);
            // 
            // txtEgg4
            // 
            this.txtEgg4.Location = new System.Drawing.Point(486, 113);
            this.txtEgg4.Name = "txtEgg4";
            this.txtEgg4.Size = new System.Drawing.Size(100, 20);
            this.txtEgg4.TabIndex = 5;
            this.txtEgg4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(335, 222);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(39, 13);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Label2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtEgg4);
            this.Controls.Add(this.txtEgg3);
            this.Controls.Add(this.txtEgg2);
            this.Controls.Add(this.txtEgg1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEgg1;
        private System.Windows.Forms.TextBox txtEgg2;
        private System.Windows.Forms.TextBox txtEgg3;
        private System.Windows.Forms.TextBox txtEgg4;
        private System.Windows.Forms.Label lblResult;
    }
}

