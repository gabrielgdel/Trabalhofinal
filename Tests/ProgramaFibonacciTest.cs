using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho
{
    [TestFixture]
    class ProgramaFibonacciTest
    {

        [TestCase]
        public void PosicaoCalculada()
        {
            Assert.AreEqual("8", ProgramaFibonacci.InformarFibonacci("6"));
        }

        [TestCase]
        public void PosicaoInvalida()
        {
            Assert.AreEqual("Erro: n deve ser maior que 0", ProgramaFibonacci.InformarFibonacci("-2"));
        }
        
        [TestCase]
        public void PosicaoInvalidaII()
        {
            Assert.AreEqual("Entre com um número inteiro positivo", ProgramaFibonacci.InformarFibonacci("a"));
        }
    }
}
