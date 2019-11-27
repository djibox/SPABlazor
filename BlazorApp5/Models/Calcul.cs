using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp5.Models
{
    public class Calcul
    {
        public Calcul()
        {
            Resultat = Val1 + Val2;
        }
        public decimal Val1 { get; set; }
        public decimal Val2 { get; set; }
        public decimal Resultat { get; set; }
    }
}
