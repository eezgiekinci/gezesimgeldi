using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatmanı.Sınıflar
{
    public class Sub_Hakkinda
    {

        //Anasayfadaki hakkında bölümüne ait:

        [Key]
        public int SubHakkindaID { get; set; }

        public string Baslik { get; set; }

        public string Aciklama { get; set; }

        public string Post1_Resim { get; set; }

        public bool Durum { get; set; }
    }
}
