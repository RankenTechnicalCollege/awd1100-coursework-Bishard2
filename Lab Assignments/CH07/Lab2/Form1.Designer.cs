namespace Lab2
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
            this.btnValidate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemNumber = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDeliveryDays = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(500, 135);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(100, 23);
            this.btnValidate.TabIndex = 0;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Number [100, 999]";
            // 
            // txtItemNumber
            // 
            this.txtItemNumber.Location = new System.Drawing.Point(500, 57);
            this.txtItemNumber.Name = "txtItemNumber";
            this.txtItemNumber.Size = new System.Drawing.Size(100, 20);
            this.txtItemNumber.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(500, 83);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 3;
            // 
            // txtDeliveryDays
            // 
            this.txtDeliveryDays.Location = new System.Drawing.Point(500, 109);
            this.txtDeliveryDays.Name = "txtDeliveryDays";
            this.txtDeliveryDays.Size = new System.Drawing.Size(100, 20);
            this.txtDeliveryDays.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity [1, 12]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estimated Delivery Days [1, 30]";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(400, 196);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 7;
            this.lblOutput.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDeliveryDays);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtItemNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValidate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemNumber;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtDeliveryDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOutput;
    }
}

