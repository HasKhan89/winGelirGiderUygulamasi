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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Girdi GirdiNesnesi { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            rdbGider.Checked = true;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            GirdiNesnesi = new Girdi();

            GirdiNesnesi.Baslik = txtBaslik.Text;
            GirdiNesnesi.Tarih = dtpTarih.Value;
            GirdiNesnesi.Not = txtNot.Text;

            if (rdbGider.Checked == true && nudTutar.Value > 0)
            {
                // Eğer gider'e pozitif girerse..
                GirdiNesnesi.Tutar = nudTutar.Value * -1;
            }
            else
            {
                if (rdbGelir.Checked && nudTutar.Value < 0)
                {
                    // Eğer gelir'e negatif girerse..
                    GirdiNesnesi.Tutar = nudTutar.Value * -1;
                }
                else
                {
                    GirdiNesnesi.Tutar = nudTutar.Value;
                }
            }

            GirdiNesnesi.Gidermi = rdbGider.Checked;

            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
