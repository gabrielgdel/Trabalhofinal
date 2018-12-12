using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho
{
    class tipoTriangulo
    {
        public static String DeterminaTipoTriangulo(int a, int b, int c)
        {
            string tipoTriangulo = "ESCALENO";
            if (a <= 0 || b <= 0 || c <= 0)
                tipoTriangulo = "INEXISTENTE";
            else if (!((a + b > c) && (a + c > b) && (b + c > a)))
                tipoTriangulo = "INEXISTENTE";
            else if (a == b)
            {
                tipoTriangulo = "ISOSCELES";
                if (b == c)
                    tipoTriangulo = "EQUILATERO";
            }
            else if (b == c || a == c)
            {
                tipoTriangulo = "ISOSCELES";
            }
            return tipoTriangulo;

        }
    }
}
