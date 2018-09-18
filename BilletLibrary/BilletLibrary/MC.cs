using System;

namespace BilletLibrary
{
    /// <summary>
    /// MC klasse til opg 3
    /// </summary>
    public class MC
    {
        public string Nummerplade;
        public DateTime Dato;

        /// <summary>
        /// Metode, der returnerer MC's pris
        /// </summary>
        /// <returns>
        /// Returns pris på 125
        /// </returns>
        public decimal Pris()
        {
            return 125;
        }

        /// <summary>
        /// Metode, der returnerer type af køretøj
        /// </summary>
        /// <returns>
        /// Returns "MC"
        /// </returns>
        public string Køretøj()
        {
            return "MC";
        }
    }
}
