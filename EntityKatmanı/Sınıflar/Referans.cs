using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatmanı.Sınıflar
{
    public class Referans
    {
        //Anasayfadaki kullanıcı yorumlarını tutar:

        [Key]
        public int ReferansID { get; set; }
        public string Musteri { get; set; }
        public string Yorum { get; set; }
        public string Musteri_Resim { get; set; }

        public bool Durum { get; set; }
    }
}
