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
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSundae = new System.Windows.Forms.CheckBox();
            this.cbSoda = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSprinkles = new System.Windows.Forms.CheckBox();
            this.cbNuts = new System.Windows.Forms.CheckBox();
            this.cbChocolate = new System.Windows.Forms.CheckBox();
            this.lstOrders = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.rdLime = new System.Windows.Forms.RadioButton();
            this.rdPeach = new System.Windows.Forms.RadioButton();
            this.rdMango = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(66, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 20);
            this.txtName.TabIndex = 0;
            // 
            // btnAddItems
            // 
            this.btnAddItems.Location = new System.Drawing.Point(66, 281);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(254, 23);
            this.btnAddItems.TabIndex = 1;
            this.btnAddItems.Text = "Add item to order";
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "What name do you want on the order?";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.Control;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(63, 111);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(165, 13);
            this.lblError.TabIndex = 3;
            this.lblError.Text = "Name required/ No food selected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Do you want a sundae?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Do you want a soda?";
            // 
            // cbSundae
            // 
            this.cbSundae.AutoSize = true;
            this.cbSundae.Location = new System.Drawing.Point(66, 153);
            this.cbSundae.Name = "cbSundae";
            this.cbSundae.Size = new System.Drawing.Size(44, 17);
            this.cbSundae.TabIndex = 6;
            this.cbSundae.Text = "Yes";
            this.cbSundae.UseVisualStyleBackColor = true;
            // 
            // cbSoda
            // 
            this.cbSoda.AutoSize = true;
            this.cbSoda.Location = new System.Drawing.Point(215, 153);
            this.cbSoda.Name = "cbSoda";
            this.cbSoda.Size = new System.Drawing.Size(44, 17);
            this.cbSoda.TabIndex = 7;
            this.cbSoda.Text = "Yes";
            this.cbSoda.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sundae Toppings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Drink Flavors";
            // 
            // cbSprinkles
            // 
            this.cbSprinkles.AutoSize = true;
            this.cbSprinkles.Location = new System.Drawing.Point(66, 198);
            this.cbSprinkles.Name = "cbSprinkles";
            this.cbSprinkles.Size = new System.Drawing.Size(69, 17);
            this.cbSprinkles.TabIndex = 10;
            this.cbSprinkles.Text = "Sprinkles";
            this.cbSprinkles.UseVisualStyleBackColor = true;
            // 
            // cbNuts
            // 
            this.cbNuts.AutoSize = true;
            this.cbNuts.Location = new System.Drawing.Point(66, 221);
            this.cbNuts.Name = "cbNuts";
            this.cbNuts.Size = new System.Drawing.Size(48, 17);
            this.cbNuts.TabIndex = 11;
            this.cbNuts.Text = "Nuts";
            this.cbNuts.UseVisualStyleBackColor = true;
            // 
            // cbChocolate
            // 
            this.cbChocolate.AutoSize = true;
            this.cbChocolate.Location = new System.Drawing.Point(66, 244);
            this.cbChocolate.Name = "cbChocolate";
            this.cbChocolate.Size = new System.Drawing.Size(104, 17);
            this.cbChocolate.TabIndex = 12;
            this.cbChocolate.Text = "Chocolate Syrup";
            this.cbChocolate.UseVisualStyleBackColor = true;
            // 
            // lstOrders
            // 
            this.lstOrders.FormattingEnabled = true;
            this.lstOrders.Location = new System.Drawing.Point(430, 76);
            this.lstOrders.Name = "lstOrders";
            this.lstOrders.Size = new System.Drawing.Size(242, 251);
            this.lstOrders.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(639, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Order";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(606, 330);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total";
            // 
            // rdLime
            // 
            this.rdLime.AutoSize = true;
            this.rdLime.Location = new System.Drawing.Point(208, 198);
            this.rdLime.Name = "rdLime";
            this.rdLime.Size = new System.Drawing.Size(79, 17);
            this.rdLime.TabIndex = 21;
            this.rdLime.TabStop = true;
            this.rdLime.Text = "Lime Flavor";
            this.rdLime.UseVisualStyleBackColor = true;
            // 
            // rdPeach
            // 
            this.rdPeach.AutoSize = true;
            this.rdPeach.Location = new System.Drawing.Point(208, 220);
            this.rdPeach.Name = "rdPeach";
            this.rdPeach.Size = new System.Drawing.Size(88, 17);
            this.rdPeach.TabIndex = 22;
            this.rdPeach.TabStop = true;
            this.rdPeach.Text = "Peach Flavor";
            this.rdPeach.UseVisualStyleBackColor = true;
            // 
            // rdMango
            // 
            this.rdMango.AutoSize = true;
            this.rdMango.Location = new System.Drawing.Point(208, 243);
            this.rdMango.Name = "rdMango";
            this.rdMango.Size = new System.Drawing.Size(90, 17);
            this.rdMango.TabIndex = 23;
            this.rdMango.TabStop = true;
            this.rdMango.Text = "Mango Flavor";
            this.rdMango.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(63, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Only 2 toppings allowed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(205, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Only 1 mixin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rdMango);
            this.Controls.Add(this.rdPeach);
            this.Controls.Add(this.rdLime);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstOrders);
            this.Controls.Add(this.cbChocolate);
            this.Controls.Add(this.cbNuts);
            this.Controls.Add(this.cbSprinkles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbSoda);
            this.Controls.Add(this.cbSundae);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbSundae;
        private System.Windows.Forms.CheckBox cbSoda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbSprinkles;
        private System.Windows.Forms.CheckBox cbNuts;
        private System.Windows.Forms.CheckBox cbChocolate;
        private System.Windows.Forms.ListBox lstOrders;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.RadioButton rdLime;
        private System.Windows.Forms.RadioButton rdPeach;
        private System.Windows.Forms.RadioButton rdMango;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

