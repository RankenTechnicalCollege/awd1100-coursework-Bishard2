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
            this.cboHero = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLikes = new System.Windows.Forms.Label();
            this.lblDislikes = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.lblBio = new System.Windows.Forms.Label();
            this.picHero = new System.Windows.Forms.PictureBox();
            this.lnkWiki = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picHero)).BeginInit();
            this.SuspendLayout();
            // 
            // cboHero
            // 
            this.cboHero.FormattingEnabled = true;
            this.cboHero.Location = new System.Drawing.Point(70, 72);
            this.cboHero.Name = "cboHero";
            this.cboHero.Size = new System.Drawing.Size(183, 21);
            this.cboHero.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(67, 117);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblLikes
            // 
            this.lblLikes.AutoSize = true;
            this.lblLikes.Location = new System.Drawing.Point(67, 143);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(32, 13);
            this.lblLikes.TabIndex = 2;
            this.lblLikes.Text = "Likes";
            // 
            // lblDislikes
            // 
            this.lblDislikes.AutoSize = true;
            this.lblDislikes.Location = new System.Drawing.Point(67, 167);
            this.lblDislikes.Name = "lblDislikes";
            this.lblDislikes.Size = new System.Drawing.Size(43, 13);
            this.lblDislikes.TabIndex = 3;
            this.lblDislikes.Text = "Dislikes";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.Location = new System.Drawing.Point(67, 194);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(42, 13);
            this.lblPower.TabIndex = 4;
            this.lblPower.Text = "Powers";
            // 
            // lblBio
            // 
            this.lblBio.AutoSize = true;
            this.lblBio.Location = new System.Drawing.Point(67, 221);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(54, 13);
            this.lblBio.TabIndex = 5;
            this.lblBio.Text = "Biography";
            // 
            // picHero
            // 
            this.picHero.Location = new System.Drawing.Point(514, 39);
            this.picHero.Name = "picHero";
            this.picHero.Size = new System.Drawing.Size(251, 297);
            this.picHero.TabIndex = 6;
            this.picHero.TabStop = false;
            // 
            // lnkWiki
            // 
            this.lnkWiki.AutoSize = true;
            this.lnkWiki.Location = new System.Drawing.Point(55, 396);
            this.lnkWiki.Name = "lnkWiki";
            this.lnkWiki.Size = new System.Drawing.Size(55, 13);
            this.lnkWiki.TabIndex = 7;
            this.lnkWiki.TabStop = true;
            this.lnkWiki.Text = "linkLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lnkWiki);
            this.Controls.Add(this.picHero);
            this.Controls.Add(this.lblBio);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.lblDislikes);
            this.Controls.Add(this.lblLikes);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cboHero);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picHero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboHero;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLikes;
        private System.Windows.Forms.Label lblDislikes;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblBio;
        private System.Windows.Forms.PictureBox picHero;
        private System.Windows.Forms.LinkLabel lnkWiki;
    }
}

