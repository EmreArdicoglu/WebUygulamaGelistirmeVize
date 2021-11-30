using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUygulamaGelistirme.Models
{
    public class Ogretmen
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Bolum { get; set; }
        public string TCKimlikNo { get; set; }
        public int Yas { get; set; }

    }
}
