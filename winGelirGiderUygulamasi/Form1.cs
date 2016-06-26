using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winGelirGiderUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Hesapla()
        {
            decimal giderToplam = 0;
            decimal gelirToplam = 0;
            decimal genelToplam = 0;

            foreach (Girdi nesne in lstGirdiler.Items)
            {
                if(nesne.Gidermi == true)
                {
                    giderToplam += nesne.Tutar;
                }
                else
                {
                    gelirToplam += nesne.Tutar;
                }

                genelToplam += nesne.Tutar;
            }

            lblGelir.Text = "Gelir Top.: " + gelirToplam.ToString();
            lblGider.Text = "Gider Top.: " + giderToplam.ToString();
            lblGenelToplam.Text = "Genel Top.: " + genelToplam.ToString();
        }



        private void mnuYeni_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            // Bu satırdan sonraki kodlar form 2 kapanınca çalışır..

            // İptal'e basılmış ise, frm2.GirdiNesnesi = null'dur.
            // Tamam'a basılmış ise, frm2.GirdiNesnesi = new'lenmiştir ve değerleri set edilmiştir.
            if (frm2.GirdiNesnesi != null)
            {
                lstGirdiler.Items.Add(frm2.GirdiNesnesi);
                Hesapla();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(lstGirdiler.SelectedIndex > -1)
            {
                lstGirdiler.Items.RemoveAt(lstGirdiler.SelectedIndex);
                Hesapla();
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir girdi seçin.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lblGider.Text = "Gider Top. : 0";
            //lblGelir.Text = "Gelir Top. : 0";
            //lblGenelToplam.Text = "Genel Top. : 0";
            Hesapla();
        }

        private void mnuCikis_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }
    }
}
