using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestExcepcion()
        {
            Exception aux = new Exception();
            Dictionary<string, Votacion.EVoto> participantes = new Dictionary<string,Votacion.EVoto>();
            Votacion vot = new Votacion("Campo", participantes);
            SerializarBinaria b = new SerializarBinaria();

            try
            {
                b.Guardar("campo", vot);
            }
            catch (ErrorArchivoExpcepcion e)
            {
                aux = e;
            }

            Assert.IsInstanceOfType(aux, typeof (ErrorArchivoExpcepcion));


        }
    }
}
