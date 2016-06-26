namespace winGelirGiderUygulamasi
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
            this.lstGirdiler = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGider = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblGelir = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstGirdiler
            // 
            this.lstGirdiler.FormattingEnabled = true;
            this.lstGirdiler.ItemHeight = 23;
            this.lstGirdiler.Location = new System.Drawing.Point(14, 32);
            this.lstGirdiler.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lstGirdiler.Name = "lstGirdiler";
            this.lstGirdiler.Size = new System.Drawing.Size(327, 280);
            this.lstGirdiler.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(591, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYeni,
            this.toolStripMenuItem1,
            this.mnuCikis});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 19);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // mnuYeni
            // 
            this.mnuYeni.Name = "mnuYeni";
            this.mnuYeni.Size = new System.Drawing.Size(152, 22);
            this.mnuYeni.Text = "Yeni";
            this.mnuYeni.Click += new System.EventHandler(this.mnuYeni_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuCikis
            // 
            this.mnuCikis.Name = "mnuCikis";
            this.mnuCikis.Size = new System.Drawing.Size(152, 22);
            this.mnuCikis.Text = "Çıkış";
            this.mnuCikis.Click += new System.EventHandler(this.mnuCikis_Click);
            // 
            // lblGider
            // 
            this.lblGider.ForeColor = System.Drawing.Color.Maroon;
            this.lblGider.Location = new System.Drawing.Point(351, 46);
            this.lblGider.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGider.Name = "lblGider";
            this.lblGider.Size = new System.Drawing.Size(226, 58);
            this.lblGider.TabIndex = 2;
            this.lblGider.Text = "label1";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(266, 320);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 32);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblGelir
            // 
            this.lblGelir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblGelir.Location = new System.Drawing.Point(351, 104);
            this.lblGelir.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGelir.Name = "lblGelir";
            this.lblGelir.Size = new System.Drawing.Size(226, 51);
            this.lblGelir.TabIndex = 2;
            this.lblGelir.Text = "label1";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGenelToplam.Location = new System.Drawing.Point(351, 169);
            this.lblGenelToplam.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(226, 62);
            this.lblGenelToplam.TabIndex = 2;
            this.lblGenelToplam.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 372);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.lblGelir);
            this.Controls.Add(this.lblGider);
            this.Controls.Add(this.lstGirdiler);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGirdiler;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuYeni;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuCikis;
        private System.Windows.Forms.Label lblGider;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblGelir;
        private System.Windows.Forms.Label lblGenelToplam;
    }
}

