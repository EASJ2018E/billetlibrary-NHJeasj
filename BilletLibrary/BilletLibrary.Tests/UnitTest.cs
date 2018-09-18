using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibrary.Tests
{
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
    }
}
