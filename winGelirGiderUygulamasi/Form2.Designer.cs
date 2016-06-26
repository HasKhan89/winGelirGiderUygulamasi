namespace winGelirGiderUygulamasi
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
            this.btnTamam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.nudTutar = new System.Windows.Forms.NumericUpDown();
            this.rdbGelir = new System.Windows.Forms.RadioButton();
            this.rdbGider = new System.Windows.Forms.RadioButton();
            this.txtNot = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTutar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(237, 334);
            this.btnTamam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(81, 34);
            this.btnTamam.TabIndex = 0;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarih :";
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(148, 334);
            this.btnIptal.Margin = new System.Windows.Forms.Padding(4);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(81, 34);
            this.btnIptal.TabIndex = 0;
            this.btnIptal.Text = "Iptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Başlık :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tutar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Not :";
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(109, 79);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(209, 27);
            this.txtBaslik.TabIndex = 2;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(109, 37);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(209, 27);
            this.dtpTarih.TabIndex = 3;
            // 
            // nudTutar
            // 
            this.nudTutar.Location = new System.Drawing.Point(109, 120);
            this.nudTutar.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudTutar.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nudTutar.Name = "nudTutar";
            this.nudTutar.Size = new System.Drawing.Size(209, 27);
            this.nudTutar.TabIndex = 4;
            // 
            // rdbGelir
            // 
            this.rdbGelir.AutoSize = true;
            this.rdbGelir.Location = new System.Drawing.Point(187, 173);
            this.rdbGelir.Name = "rdbGelir";
            this.rdbGelir.Size = new System.Drawing.Size(60, 23);
            this.rdbGelir.TabIndex = 5;
            this.rdbGelir.TabStop = true;
            this.rdbGelir.Text = "Gelir";
            this.rdbGelir.UseVisualStyleBackColor = true;
            // 
            // rdbGider
            // 
            this.rdbGider.AutoSize = true;
            this.rdbGider.Location = new System.Drawing.Point(253, 173);
            this.rdbGider.Name = "rdbGider";
            this.rdbGider.Size = new System.Drawing.Size(65, 23);
            this.rdbGider.TabIndex = 5;
            this.rdbGider.TabStop = true;
            this.rdbGider.Text = "Gider";
            this.rdbGider.UseVisualStyleBackColor = true;
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(109, 218);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(209, 82);
            this.txtNot.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 381);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.rdbGider);
            this.Controls.Add(this.rdbGelir);
            this.Controls.Add(this.nudTutar);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTamam);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTutar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.NumericUpDown nudTutar;
        private System.Windows.Forms.RadioButton rdbGelir;
        private System.Windows.Forms.RadioButton rdbGider;
        private System.Windows.Forms.TextBox txtNot;
    }
}