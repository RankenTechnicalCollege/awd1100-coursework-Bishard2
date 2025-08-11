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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbUnframed = new System.Windows.Forms.RadioButton();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbMatted = new System.Windows.Forms.RadioButton();
            this.rbFramed = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.rbSteel = new System.Windows.Forms.RadioButton();
            this.rbOak = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rbPine = new System.Windows.Forms.RadioButton();
            this.rbAntique = new System.Windows.Forms.RadioButton();
            this.rbModern = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rbSimple = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbWhite = new System.Windows.Forms.RadioButton();
            this.rbSilver = new System.Windows.Forms.RadioButton();
            this.rbGold = new System.Windows.Forms.RadioButton();
            this.rbVintage = new System.Windows.Forms.RadioButton();
            this.rbEclectic = new System.Windows.Forms.RadioButton();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.gbStyle = new System.Windows.Forms.GroupBox();
            this.gbMaterial = new System.Windows.Forms.GroupBox();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.gbStyle.SuspendLayout();
            this.gbMaterial.SuspendLayout();
            this.gbColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(20, 362);
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
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width (in)";
            // 
            // rbUnframed
            // 
            this.rbUnframed.AutoSize = true;
            this.rbUnframed.Location = new System.Drawing.Point(29, 134);
            this.rbUnframed.Name = "rbUnframed";
            this.rbUnframed.Size = new System.Drawing.Size(71, 17);
            this.rbUnframed.TabIndex = 2;
            this.rbUnframed.TabStop = true;
            this.rbUnframed.Text = "Unframed";
            this.rbUnframed.UseVisualStyleBackColor = true;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(87, 40);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(286, 20);
            this.txtWidth.TabIndex = 3;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(87, 66);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(286, 20);
            this.txtHeight.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Height (in)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Frame";
            // 
            // rbMatted
            // 
            this.rbMatted.AutoSize = true;
            this.rbMatted.Location = new System.Drawing.Point(29, 157);
            this.rbMatted.Name = "rbMatted";
            this.rbMatted.Size = new System.Drawing.Size(58, 17);
            this.rbMatted.TabIndex = 7;
            this.rbMatted.TabStop = true;
            this.rbMatted.Text = "Matted";
            this.rbMatted.UseVisualStyleBackColor = true;
            // 
            // rbFramed
            // 
            this.rbFramed.AutoSize = true;
            this.rbFramed.Location = new System.Drawing.Point(29, 174);
            this.rbFramed.Name = "rbFramed";
            this.rbFramed.Size = new System.Drawing.Size(60, 17);
            this.rbFramed.TabIndex = 8;
            this.rbFramed.TabStop = true;
            this.rbFramed.Text = "Framed";
            this.rbFramed.UseVisualStyleBackColor = true;
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(6, 84);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(54, 17);
            this.rbGreen.TabIndex = 12;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(6, 61);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(45, 17);
            this.rbRed.TabIndex = 11;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Color";
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Location = new System.Drawing.Point(6, 38);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(52, 17);
            this.rbBlack.TabIndex = 9;
            this.rbBlack.TabStop = true;
            this.rbBlack.Text = "Black";
            this.rbBlack.UseVisualStyleBackColor = true;
            // 
            // rbSteel
            // 
            this.rbSteel.AutoSize = true;
            this.rbSteel.Location = new System.Drawing.Point(6, 84);
            this.rbSteel.Name = "rbSteel";
            this.rbSteel.Size = new System.Drawing.Size(49, 17);
            this.rbSteel.TabIndex = 16;
            this.rbSteel.TabStop = true;
            this.rbSteel.Text = "Steel";
            this.rbSteel.UseVisualStyleBackColor = true;
            // 
            // rbOak
            // 
            this.rbOak.AutoSize = true;
            this.rbOak.Location = new System.Drawing.Point(6, 61);
            this.rbOak.Name = "rbOak";
            this.rbOak.Size = new System.Drawing.Size(45, 17);
            this.rbOak.TabIndex = 15;
            this.rbOak.TabStop = true;
            this.rbOak.Text = "Oak";
            this.rbOak.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Material";
            // 
            // rbPine
            // 
            this.rbPine.AutoSize = true;
            this.rbPine.Location = new System.Drawing.Point(6, 38);
            this.rbPine.Name = "rbPine";
            this.rbPine.Size = new System.Drawing.Size(46, 17);
            this.rbPine.TabIndex = 13;
            this.rbPine.TabStop = true;
            this.rbPine.Text = "Pine";
            this.rbPine.UseVisualStyleBackColor = true;
            // 
            // rbAntique
            // 
            this.rbAntique.AutoSize = true;
            this.rbAntique.Location = new System.Drawing.Point(6, 85);
            this.rbAntique.Name = "rbAntique";
            this.rbAntique.Size = new System.Drawing.Size(61, 17);
            this.rbAntique.TabIndex = 20;
            this.rbAntique.TabStop = true;
            this.rbAntique.Text = "Antique";
            this.rbAntique.UseVisualStyleBackColor = true;
            // 
            // rbModern
            // 
            this.rbModern.AutoSize = true;
            this.rbModern.Location = new System.Drawing.Point(6, 62);
            this.rbModern.Name = "rbModern";
            this.rbModern.Size = new System.Drawing.Size(61, 17);
            this.rbModern.TabIndex = 19;
            this.rbModern.TabStop = true;
            this.rbModern.Text = "Modern";
            this.rbModern.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Style";
            // 
            // rbSimple
            // 
            this.rbSimple.AutoSize = true;
            this.rbSimple.Location = new System.Drawing.Point(6, 39);
            this.rbSimple.Name = "rbSimple";
            this.rbSimple.Size = new System.Drawing.Size(56, 17);
            this.rbSimple.TabIndex = 17;
            this.rbSimple.TabStop = true;
            this.rbSimple.Text = "Simple";
            this.rbSimple.UseVisualStyleBackColor = true;
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(6, 107);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(46, 17);
            this.rbBlue.TabIndex = 21;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            // 
            // rbWhite
            // 
            this.rbWhite.AutoSize = true;
            this.rbWhite.Location = new System.Drawing.Point(6, 130);
            this.rbWhite.Name = "rbWhite";
            this.rbWhite.Size = new System.Drawing.Size(53, 17);
            this.rbWhite.TabIndex = 22;
            this.rbWhite.TabStop = true;
            this.rbWhite.Text = "White";
            this.rbWhite.UseVisualStyleBackColor = true;
            // 
            // rbSilver
            // 
            this.rbSilver.AutoSize = true;
            this.rbSilver.Location = new System.Drawing.Point(6, 107);
            this.rbSilver.Name = "rbSilver";
            this.rbSilver.Size = new System.Drawing.Size(51, 17);
            this.rbSilver.TabIndex = 23;
            this.rbSilver.TabStop = true;
            this.rbSilver.Text = "Silver";
            this.rbSilver.UseVisualStyleBackColor = true;
            // 
            // rbGold
            // 
            this.rbGold.AutoSize = true;
            this.rbGold.Location = new System.Drawing.Point(6, 130);
            this.rbGold.Name = "rbGold";
            this.rbGold.Size = new System.Drawing.Size(47, 17);
            this.rbGold.TabIndex = 24;
            this.rbGold.TabStop = true;
            this.rbGold.Text = "Gold";
            this.rbGold.UseVisualStyleBackColor = true;
            // 
            // rbVintage
            // 
            this.rbVintage.AutoSize = true;
            this.rbVintage.Location = new System.Drawing.Point(6, 108);
            this.rbVintage.Name = "rbVintage";
            this.rbVintage.Size = new System.Drawing.Size(61, 17);
            this.rbVintage.TabIndex = 25;
            this.rbVintage.TabStop = true;
            this.rbVintage.Text = "Vintage";
            this.rbVintage.UseVisualStyleBackColor = true;
            // 
            // rbEclectic
            // 
            this.rbEclectic.AutoSize = true;
            this.rbEclectic.Location = new System.Drawing.Point(6, 131);
            this.rbEclectic.Name = "rbEclectic";
            this.rbEclectic.Size = new System.Drawing.Size(63, 17);
            this.rbEclectic.TabIndex = 26;
            this.rbEclectic.TabStop = true;
            this.rbEclectic.Text = "Eclectic";
            this.rbEclectic.UseVisualStyleBackColor = true;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(170, 367);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 27;
            this.lblCost.Text = "Cost";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(24, 413);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(37, 13);
            this.lblOutput.TabIndex = 28;
            this.lblOutput.Text = "output";
            // 
            // gbStyle
            // 
            this.gbStyle.Controls.Add(this.rbAntique);
            this.gbStyle.Controls.Add(this.rbSimple);
            this.gbStyle.Controls.Add(this.label6);
            this.gbStyle.Controls.Add(this.rbEclectic);
            this.gbStyle.Controls.Add(this.rbModern);
            this.gbStyle.Controls.Add(this.rbVintage);
            this.gbStyle.Location = new System.Drawing.Point(215, 199);
            this.gbStyle.Name = "gbStyle";
            this.gbStyle.Size = new System.Drawing.Size(72, 157);
            this.gbStyle.TabIndex = 29;
            this.gbStyle.TabStop = false;
            // 
            // gbMaterial
            // 
            this.gbMaterial.Controls.Add(this.rbSteel);
            this.gbMaterial.Controls.Add(this.rbPine);
            this.gbMaterial.Controls.Add(this.label5);
            this.gbMaterial.Controls.Add(this.rbOak);
            this.gbMaterial.Controls.Add(this.rbGold);
            this.gbMaterial.Controls.Add(this.rbSilver);
            this.gbMaterial.Location = new System.Drawing.Point(119, 199);
            this.gbMaterial.Name = "gbMaterial";
            this.gbMaterial.Size = new System.Drawing.Size(66, 160);
            this.gbMaterial.TabIndex = 30;
            this.gbMaterial.TabStop = false;
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.rbRed);
            this.gbColor.Controls.Add(this.rbBlack);
            this.gbColor.Controls.Add(this.label4);
            this.gbColor.Controls.Add(this.rbGreen);
            this.gbColor.Controls.Add(this.rbBlue);
            this.gbColor.Controls.Add(this.rbWhite);
            this.gbColor.Location = new System.Drawing.Point(27, 199);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(68, 157);
            this.gbColor.TabIndex = 31;
            this.gbColor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.gbMaterial);
            this.Controls.Add(this.gbStyle);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.rbFramed);
            this.Controls.Add(this.rbMatted);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.rbUnframed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbStyle.ResumeLayout(false);
            this.gbStyle.PerformLayout();
            this.gbMaterial.ResumeLayout(false);
            this.gbMaterial.PerformLayout();
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbUnframed;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbMatted;
        private System.Windows.Forms.RadioButton rbFramed;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbBlack;
        private System.Windows.Forms.RadioButton rbSteel;
        private System.Windows.Forms.RadioButton rbOak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbPine;
        private System.Windows.Forms.RadioButton rbAntique;
        private System.Windows.Forms.RadioButton rbModern;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbSimple;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbWhite;
        private System.Windows.Forms.RadioButton rbSilver;
        private System.Windows.Forms.RadioButton rbGold;
        private System.Windows.Forms.RadioButton rbVintage;
        private System.Windows.Forms.RadioButton rbEclectic;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.GroupBox gbStyle;
        private System.Windows.Forms.GroupBox gbMaterial;
        private System.Windows.Forms.GroupBox gbColor;
    }
}

