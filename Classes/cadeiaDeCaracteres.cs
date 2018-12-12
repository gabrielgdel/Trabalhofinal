using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho

{
    class cadeiaDeCaracteres
    {
        public static string BuscarNaCadeia(string cadeiaDeCaracteres, char caractereBuscado) {
            string resultado = "O caractere não pertence à cadeia informada";

            if (caractereBuscado == ' ')
            {
                resultado = "Erro: nenhum caractere informado.";
            }
            else if (cadeiaDeCaracteres.Length <= 0 || cadeiaDeCaracteres.Length > 20)
            {
                resultado = "Erro: cadeia inválida";
            }
            else
            {
                for (int i = 0; i < cadeiaDeCaracteres.Length; i++)
                {
                    if (Convert.ToString(cadeiaDeCaracteres[i]) == Convert.ToString(caractereBuscado))                    
                        resultado = Convert.ToString(i);                     
                }
            }
            return resultado;
        }
    }
}
