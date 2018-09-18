using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibrary.Tests
{
    // Tester f�rst Pris()
    /// <summary>
    /// Test klasse
    /// </summary>
    [TestClass]
    public class UnitTest
    {
        /// <summary>
        /// Tester Pris() fra klassen Bil, forventer 240
        /// </summary>
        [TestMethod]
        public void BilPrisTest()
        {
            // arange
            var bil = new Bil();

            // act
            decimal pris = bil.Pris();

            // assert
            Assert.AreEqual(240, pris);
        }
        /// <summary>
        /// Tester Pris() fra klassen MC, forventer 125
        /// </summary>
        [TestMethod]
        public void MCPrisTest()
        {
            // arange
            var mc = new MC();

            // act
            decimal pris = mc.Pris();

            // assert
            Assert.AreEqual(125, pris);
        }


        // Tester TypeK�ret�j()
        /// <summary>
        /// Tester type af k�ret�j() fra klassen Bil, forventer "bil"
        /// </summary>
        [TestMethod]
        public void BilTypeK�ret�jTest()
        {
            // arange
            var bil = new Bil();

            // act
            string type = bil.TypeK�ret�j();

            // assert
            Assert.AreEqual("bil", type);
        }

        /// <summary>
        /// Tester type af k�ret�j() fra klassen MC, forventer "MC"
        /// </summary>
        [TestMethod]
        public void MCK�ret�jTest()
        {
            // arange
            var mc = new MC();

            // act
            string type = mc.TypeK�ret�j();

            // assert
            Assert.AreEqual("MC", type);
        }


        // Tester SkrivNummerplade()
        /// <summary>
        /// Tester om nummerpladen kan v�re p� et tegn som forventet
        /// </summary>
        [TestMethod]
        public void SkrivNummerpladeTestEtTegn()
        {
            // arange
            var bil = new Bil();

            // act
            string nummerplade = bil.SkrivNummerplade("1");

            // assert
            Assert.AreEqual("1", nummerplade);
        }

        /// <summary>
        /// Tester om nummerpladen kan v�re p� syv tegn som forventet
        /// </summary>
        [TestMethod]
        public void SkrivNummerpladeTestSyvTegn()
        {
            // arange
            var bil = new Bil();

            // act
            string nummerplade = bil.SkrivNummerplade("1234567");

            // assert
            Assert.AreEqual("1234567", nummerplade);
        }

        /// <summary>
        /// Tester om SkrivNummerplade() kan tage flere end 7 tegn, forventer exception
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SkrivNummerpladeTestForMangeTegn()
        {
            // arange
            var bil = new Bil();

            // act
            string nummerplade = bil.SkrivNummerplade("12345678"); // forventer at der kastes exception her

            // assert
            Assert.Fail(); // hvis systemet k�rer hertil er exceptionen fejlet
        }
    }
}
