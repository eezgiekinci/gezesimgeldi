using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatmanı.Sınıflar
{
    public class OneCikanlar
    {
        //Anasayfadaki öne çıkan turları tutar:

        [Key]
        public int OneCikanlarID { get; set; }

        public string Post1_Baslik { get; set; }

        public string Post1_Aciklama { get; set; }

        public string Post1_Resim { get; set; }

        public bool Durum { get; set; }
    }
}
