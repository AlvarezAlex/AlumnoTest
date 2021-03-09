using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pelicula;
using System.IO;

namespace PeliculaTest
{
    [TestClass]
    public class PeluculaTest
    {
        [TestMethod]
        public void Constructor()
        {
            Pelicula.Pelicula p1 = new Pelicula.Pelicula("El codigo enigma", 2014, new Categoria("Biografica", "Biopic"), Clasificacion.PG13);

            Assert.AreEqual("El codigo enigma", p1.Titulo);
            Assert.AreEqual(2015, p1.Año);
            

        }
        [TestClass]
        public class ActorTest
        { 
            [TestMethod]
            public void ImprimeTest()
            {
                Actor benedict = new Actor(1000, "Benedict Cumberbatch", "London, England, Uk");
                using (var sw = new StringWriter())
                {
                    Console.SetOut(sw);
                    benedict.Imprime();
                    var result = sw.ToString().Trim();
                    Assert.AreEqual("Benedict Cumberbatch(London, England, Uk)",result);
                }
                    
            }
        }

    }
}
