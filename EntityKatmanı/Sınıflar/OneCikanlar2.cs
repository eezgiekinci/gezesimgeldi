using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatmanı.Sınıflar
{
    public class OneCikanlar2
    {
        //Anasayfadaki öne çıkan turları tutar:

        [Key]
        public int OneCikanlar_2_ID { get; set; }

        public string Post2_Baslik { get; set; }

        public string Post2_Aciklama { get; set; }

        public string Post2_Resim { get; set; }

        public bool Durum { get; set; }
    }
}
