using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica.Negocio;

namespace Calculadora.Tests
{
    [TestClass]
    public class Sumas
    {
        [TestMethod]
        public void SumarUnoMasDos()
        {
            //Paso 1. Defino el escenario de la prueba, Declaro mi variable que se llama elPrimerOperando
            var elPrimerOperando = 1;
            var elSegundoOperando = 2;
            var elResultadoEsperado = 3;

            //Paso 2. Invoco al metodo que se desea validar
            var laSuma = new Suma();
            var elResultadoReal = laSuma.Operar(elPrimerOperando, elSegundoOperando);

            //Paso 3. Comparacion del resultado obtenido con el esperado
            Assert.AreEqual(elResultadoEsperado, elResultadoReal);

        }
    }
}
