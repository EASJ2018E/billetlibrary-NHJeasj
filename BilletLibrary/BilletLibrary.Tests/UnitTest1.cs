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
        /// Tester om Pris er 240 som forventet
        /// </summary>
        [TestMethod]
        public void PrisTest()
        {
            // arange
            var bil = new Bil();

            // act
            decimal pris = bil.Pris();

            // assert
            Assert.AreEqual(240, pris);
        }
        
        /// <summary>
        /// Tester type af køretøj, forventer "bil"
        /// </summary>
        [TestMethod]
        public void KøretøjTest()
        {
            // arange
            var bil = new Bil();

            // act
            string køretøj = bil.Køretøj();

            // assert
            Assert.AreEqual("bil", køretøj);
        }
    }
}
