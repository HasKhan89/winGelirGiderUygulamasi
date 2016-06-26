using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winGelirGiderUygulamasi
{
    public class Girdi
    {
        public DateTime Tarih { get; set; }
        public string Baslik { get; set; }
        public decimal Tutar { get; set; }
        public bool Gidermi { get; set; }
        public string Not { get; set; }

        public override string ToString()
        {
            return Baslik + " - " + Tarih.ToShortDateString();
        }
    }
}
