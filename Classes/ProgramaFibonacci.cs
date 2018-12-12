using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho
{
    class ProgramaFibonacci
    {
        public static string InformarFibonacci(string posicao)
        {
            int a = 0, b = 1, c = 0, p = 0;
            if(Int32.TryParse(posicao, out p) == false){
                return "Entre com um número inteiro positivo";
            }
            if(Convert.ToInt32(posicao) < 1)
            {
                return "Erro: n deve ser maior que 0";
            }
            else
            {           
                for (int i = 0; i < p; i++)
                {
                    c = a;
                    a = b;
                    b = c + b;                    
                }
                return Convert.ToString(a);
            }
        }
    }
}
