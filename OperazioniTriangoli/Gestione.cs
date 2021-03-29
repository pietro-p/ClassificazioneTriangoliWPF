using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperazioniTriangoli
{
    public class Gestione
    {
        public static string Classificazione(double n1, double n2, double n3)
        {
            string tipo = "";
            if (n1 != n2 && n1 != n3 && n2 != n3)
            {
                tipo = "Triangolo Scaleno";
            }
            else if (n1 != n2 || n1 != n3 || n2 != n3)
            {
                tipo = "Triangolo Isoscele";
            }
            else if (n1 == n2 && n1 == n3 && n2 == n3)
            {
                tipo = "Triangolo Equilatero";
            }
            return tipo;
        }
        public static double Perimetro(double n1, double n2, double n3)
        {
            double p = n1 + n2 + n3;
            return p;
        }
    }
}
