using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatmanı.Sınıflar
{
    public class Iletisim
    {
        //Anasayfadaki iletisim bölümüne ait:

        [Key]
        public int IletisimID { get; set; }
        public string Aciklama { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Harita { get; set; }
        public string Durum { get; set; }
    }

}
