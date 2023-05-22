using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatmanı.Sınıflar
{
    public class Hakkinda2
    {
        //Anasayfadaki hakkında bölümüne ait:

        [Key]
        public int Hakkinda2_ID { get; set; }
        public string Baslik1 { get; set; }
        public string Baslik2 { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public bool Durum { get; set; }
    }
}
