using System;

namespace BilletLibrary
{
    /// <summary>
    /// Abstract klasse for køretøjer, som køretøjsklasse arver fra
    /// </summary>
    public abstract class Køretøj
    {
        public string Nummerplade;
        public DateTime Dato;

        /// <summary>
        /// Abstract metode, der skal overrides og angive pris på køretøj
        /// </summary>
        /// <returns>
        /// Returns Pris i decimal
        /// </returns>
        public abstract decimal Pris();

        /// <summary>
        /// Abstract metode, der skal overrides og angive type af køretøj
        /// </summary>
        /// <returns>
        /// Returns type af "køretøj" i string
        /// </returns>
        public abstract string TypeKøretøj();

        /// <summary>
        /// Virtual metode, hvori nummerplade skrives ind. 
        /// Kan overskrives
        /// </summary>
        /// <returns>
        /// Returns string værdi for "nummerplade" på max 7 tegn
        /// </returns>
        public virtual string SkrivNummerplade(string nummerpladeInput)
        {
            Nummerplade = nummerpladeInput;
            if (Nummerplade.Length > 7)
            {
                throw new ArgumentException("Nummerpladen er forkert indtastet");
            }
            return Nummerplade;
        }
    }
}
