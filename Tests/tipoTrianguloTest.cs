using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace trabalho

{
    [TestFixture]
    class tipoTrianguloTest
    {

        const string INEXISTENTE = "INEXISTENTE";
        const string EQUILATERO = "EQUILATERO";
        const string ISOSCELES = "ISOSCELES";
        const string ESCALENO = "ESCALENO";

        [TestCase]
        public void tipoInexistente()
        {
            Assert.AreEqual(INEXISTENTE, tipoTriangulo.DeterminaTipoTriangulo(0, 0, 0));
        }

        [TestCase]
        public void tipoInexistenteII()
        {
            Assert.AreEqual(INEXISTENTE, tipoTriangulo.DeterminaTipoTriangulo(1, 2, 3));
        }

        [TestCase]
        public void tipoEquilatero()
        {
            Assert.AreEqual(EQUILATERO, tipoTriangulo.DeterminaTipoTriangulo(1, 1, 1));
        }

        [TestCase]
        public void tipoIsosceles()
        {
            Assert.AreEqual(ISOSCELES, tipoTriangulo.DeterminaTipoTriangulo(1, 2, 2));
        }

        [TestCase]
        public void tipoIsoscelesII()
        {
            Assert.AreEqual(ISOSCELES, tipoTriangulo.DeterminaTipoTriangulo(2, 2, 1));
        }

        [TestCase]
        public void tipoEscaleno() { 
            Assert.AreEqual(ESCALENO, tipoTriangulo.DeterminaTipoTriangulo(2, 3, 4));
        }
    }
}
