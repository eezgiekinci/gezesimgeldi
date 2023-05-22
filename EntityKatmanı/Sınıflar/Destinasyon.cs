using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatmanı.Sınıflar
{
    public class Destinasyon
    {
        //Anasayfadaki tura ait gerekli bilgileri tutar:

        [Key]
        public int DestinasyonID { get; set; }
        public string Sehir { get; set; }
        public string Konaklama_Suresi { get; set; }
        public double Fiyat { get; set; }
        public string Resim { get; set; }
        public string Aciklama { get; set; }
        public int Kapasite { get; set; }
        public bool Durum { get; set; }




    }
}
