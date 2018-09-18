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
        /// Tester type af k�ret�j, forventer "bil"
        /// </summary>
        [TestMethod]
        public void K�ret�jTest()
        {
            // arange
            var bil = new Bil();

            // act
            string k�ret�j = bil.K�ret�j();

            // assert
            Assert.AreEqual("bil", k�ret�j);
        }
    }
}
