using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teste;

namespace trabalho
{
    [TestFixture]
    class cadeiacaracteresTest
    {

        [TestCase]
        public void CaractereEncontrado()
        {
            Assert.AreEqual("1", cadeiaDeCaracteres.BuscarNaCadeia("abc", 'b'));
        }


        [TestCase]
        public void CaractereNaoEncontrado()
        {
            Assert.AreEqual("O caractere não pertence à cadeia informada", cadeiaDeCaracteres.BuscarNaCadeia("abc", 'd'));
        }
      
        [TestCase]
        public void CadeiaInvalida()
        {
            Assert.AreEqual("Erro: cadeia inválida", cadeiaDeCaracteres.BuscarNaCadeia("abaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaasssaaac", 'g'));
        }

        [TestCase]
        public void CaractereNaoInformado()
        {
            Assert.AreEqual("Erro: nenhum caractere informado.", cadeiaDeCaracteres.BuscarNaCadeia("abc", ' '));
        }
    }
}
