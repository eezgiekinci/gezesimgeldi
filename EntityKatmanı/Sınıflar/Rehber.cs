using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatmanı.Sınıflar
{
    public class Rehber
    {

        //Anasayfadaki rehberleri tutar:

        [Key]
        public int RehberID { get; set; }
        public string RehberAdi { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string Durum { get; set; }
    }
}
