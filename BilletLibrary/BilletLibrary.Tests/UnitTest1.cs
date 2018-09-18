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
        /// Tester type af køretøj() fra klassen Bil, forventer "bil"
        /// </summary>
        [TestMethod]
        public void BilKøretøjTest()
        {
            // arange
            var bil = new Bil();

            // act
            string køretøj = bil.Køretøj();

            // assert
            Assert.AreEqual("bil", køretøj);
        }

        /// <summary>
        /// Tester type af køretøj() fra klassen MC, forventer "MC"
        /// </summary>
        [TestMethod]
        public void MCKøretøjTest()
        {
            // arange
            var mc = new MC();

            // act
            string køretøj = mc.Køretøj();

            // assert
            Assert.AreEqual("MC", køretøj);
        }
    }
}
