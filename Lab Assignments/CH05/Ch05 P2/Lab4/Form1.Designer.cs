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
            this.btnDanielle = new System.Windows.Forms.Button();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtSaleAmount = new System.Windows.Forms.TextBox();
            this.btnEdward = new System.Windows.Forms.Button();
            this.btnFrancis = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblDanielleSales = new System.Windows.Forms.Label();
            this.lblEdwardSales = new System.Windows.Forms.Label();
            this.lblFrancisSales = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblTopSalesperson = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDanielle
            // 
            this.btnDanielle.Location = new System.Drawing.Point(74, 117);
            this.btnDanielle.Name = "btnDanielle";
            this.btnDanielle.Size = new System.Drawing.Size(75, 23);
            this.btnDanielle.TabIndex = 0;
            this.btnDanielle.Text = "Danielle";
            this.btnDanielle.UseVisualStyleBackColor = true;
            this.btnDanielle.Click += new System.EventHandler(this.btnDanielle_Click);
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(71, 75);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(126, 13);
            this.lblPrompt.TabIndex = 1;
            this.lblPrompt.Text = "How much was the sale?";
            // 
            // txtSaleAmount
            // 
            this.txtSaleAmount.Location = new System.Drawing.Point(74, 91);
            this.txtSaleAmount.Name = "txtSaleAmount";
            this.txtSaleAmount.Size = new System.Drawing.Size(237, 20);
            this.txtSaleAmount.TabIndex = 2;
            // 
            // btnEdward
            // 
            this.btnEdward.Location = new System.Drawing.Point(155, 117);
            this.btnEdward.Name = "btnEdward";
            this.btnEdward.Size = new System.Drawing.Size(75, 23);
            this.btnEdward.TabIndex = 3;
            this.btnEdward.Text = "Edward";
            this.btnEdward.UseVisualStyleBackColor = true;
            this.btnEdward.Click += new System.EventHandler(this.btnEdward_Click);
            // 
            // btnFrancis
            // 
            this.btnFrancis.Location = new System.Drawing.Point(236, 117);
            this.btnFrancis.Name = "btnFrancis";
            this.btnFrancis.Size = new System.Drawing.Size(75, 23);
            this.btnFrancis.TabIndex = 4;
            this.btnFrancis.Text = "Francis";
            this.btnFrancis.UseVisualStyleBackColor = true;
            this.btnFrancis.Click += new System.EventHandler(this.btnFrancis_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(317, 117);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblDanielleSales
            // 
            this.lblDanielleSales.AutoSize = true;
            this.lblDanielleSales.Location = new System.Drawing.Point(71, 143);
            this.lblDanielleSales.Name = "lblDanielleSales";
            this.lblDanielleSales.Size = new System.Drawing.Size(71, 13);
            this.lblDanielleSales.TabIndex = 6;
            this.lblDanielleSales.Text = "DanielleSales";
            // 
            // lblEdwardSales
            // 
            this.lblEdwardSales.AutoSize = true;
            this.lblEdwardSales.Location = new System.Drawing.Point(71, 165);
            this.lblEdwardSales.Name = "lblEdwardSales";
            this.lblEdwardSales.Size = new System.Drawing.Size(69, 13);
            this.lblEdwardSales.TabIndex = 7;
            this.lblEdwardSales.Text = "EdwardSales";
            // 
            // lblFrancisSales
            // 
            this.lblFrancisSales.AutoSize = true;
            this.lblFrancisSales.Location = new System.Drawing.Point(71, 187);
            this.lblFrancisSales.Name = "lblFrancisSales";
            this.lblFrancisSales.Size = new System.Drawing.Size(67, 13);
            this.lblFrancisSales.TabIndex = 8;
            this.lblFrancisSales.Text = "FrancisSales";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(71, 209);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(60, 13);
            this.lblGrandTotal.TabIndex = 9;
            this.lblGrandTotal.Text = "GrandTotal";
            // 
            // lblTopSalesperson
            // 
            this.lblTopSalesperson.AutoSize = true;
            this.lblTopSalesperson.Location = new System.Drawing.Point(71, 232);
            this.lblTopSalesperson.Name = "lblTopSalesperson";
            this.lblTopSalesperson.Size = new System.Drawing.Size(85, 13);
            this.lblTopSalesperson.TabIndex = 10;
            this.lblTopSalesperson.Text = "TopSalesPerson";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTopSalesperson);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblFrancisSales);
            this.Controls.Add(this.lblEdwardSales);
            this.Controls.Add(this.lblDanielleSales);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFrancis);
            this.Controls.Add(this.btnEdward);
            this.Controls.Add(this.txtSaleAmount);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.btnDanielle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDanielle;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtSaleAmount;
        private System.Windows.Forms.Button btnEdward;
        private System.Windows.Forms.Button btnFrancis;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblDanielleSales;
        private System.Windows.Forms.Label lblEdwardSales;
        private System.Windows.Forms.Label lblFrancisSales;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblTopSalesperson;
    }
}

