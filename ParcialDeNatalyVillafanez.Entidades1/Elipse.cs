using ParcialDeNatalyVillafanez.Entidades1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialDeNatalyVillafanez.WindowsForms
{
    public class Elipse
    {
        public double SemiejeMayor { get; set; }
        public double SemiejeMenor { get; set; }
        public TipoTrazo TipoDeTrazo { get; set; }
        public double GetArea()
        {
            var area = Math.PI * SemiejeMayor * SemiejeMenor;
            return area;

        }
        public double GetPerimetro()
        {
            var perimetro = (2 * Math.PI) * (Math.Sqrt((Math.Pow(SemiejeMayor, 2) + Math.Pow(SemiejeMenor, 2)) / 2));
            return perimetro;
        }
    }
}
