using System;

namespace BilletLibrary
{
    /// <summary>
    /// Bil klassen
    /// Indeholder basic bil info
    /// </summary>
    public class Bil
    {
        public string Nummerplade;
        public DateTime Dato;

        /// <summary>
        /// Metode, der returnerer bilens pris
        /// </summary>
        /// <returns>
        /// Returns pris på 240
        /// </returns>
        public decimal Pris()
        {
            return 240;
        }

        /// <summary>
        /// Metode, der returnerer type af køretøj
        /// </summary>
        /// <returns>
        /// Returns "bil"
        /// </returns>
        public string Køretøj()
        {
            return "bil";
        }
    }
}