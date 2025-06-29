namespace Lab6
{
    partial class Form6
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWood = new System.Windows.Forms.TextBox();
            this.txtDrawers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCostWood = new System.Windows.Forms.Label();
            this.lblCostDrawers = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(97, 144);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Estimate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type of Wood";
            // 
            // txtWood
            // 
            this.txtWood.Location = new System.Drawing.Point(97, 105);
            this.txtWood.Name = "txtWood";
            this.txtWood.Size = new System.Drawing.Size(100, 20);
            this.txtWood.TabIndex = 2;
            // 
            // txtDrawers
            // 
            this.txtDrawers.Location = new System.Drawing.Point(203, 105);
            this.txtDrawers.Name = "txtDrawers";
            this.txtDrawers.Size = new System.Drawing.Size(100, 20);
            this.txtDrawers.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Drawers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cost of Wood";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cost of Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total Cost";
            // 
            // lblCostWood
            // 
            this.lblCostWood.AutoSize = true;
            this.lblCostWood.Location = new System.Drawing.Point(96, 225);
            this.lblCostWood.Name = "lblCostWood";
            this.lblCostWood.Size = new System.Drawing.Size(60, 13);
            this.lblCostWood.TabIndex = 8;
            this.lblCostWood.Text = "Wood Cost";
            // 
            // lblCostDrawers
            // 
            this.lblCostDrawers.AutoSize = true;
            this.lblCostDrawers.Location = new System.Drawing.Point(174, 225);
            this.lblCostDrawers.Name = "lblCostDrawers";
            this.lblCostDrawers.Size = new System.Drawing.Size(70, 13);
            this.lblCostDrawers.TabIndex = 9;
            this.lblCostDrawers.Text = "Drawers Cost";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(262, 225);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(55, 13);
            this.lblTotalCost.TabIndex = 10;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblCostDrawers);
            this.Controls.Add(this.lblCostWood);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDrawers);
            this.Controls.Add(this.txtWood);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form6";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWood;
        private System.Windows.Forms.TextBox txtDrawers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCostWood;
        private System.Windows.Forms.Label lblCostDrawers;
        private System.Windows.Forms.Label lblTotalCost;
    }
}

