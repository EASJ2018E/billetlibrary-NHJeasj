using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibrary.Tests
{
    /// <summary>
    /// Test klasse
    /// </summary>
    [TestClass]
    public class UnitTest1
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
        public void BilK�ret�jTest()
        {
            // arange
            var bil = new Bil();

            // act
            string k�ret�j = bil.K�ret�j();

            // assert
            Assert.AreEqual("bil", k�ret�j);
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
            string k�ret�j = mc.K�ret�j();

            // assert
            Assert.AreEqual("MC", k�ret�j);
        }
    }
}
