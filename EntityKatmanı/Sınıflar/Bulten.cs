using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityKatmanı.Sınıflar
{
    public class Bulten
    {
        //Anasayfadaki bülten (newsletter) bölümüne ait:

        [Key]
        public int BultenID { get; set; }
        public string Mail { get; set; }
    }
}
