namespace BilletLibrary
{
    /// <inheritdoc />
    /// <summary>
    /// Bil klassen, nedarver fra Køretøj klassen
    /// </summary>
    public class Bil : Køretøj
    {
        // public string Nummerplade;
        // public DateTime Dato;

        /// <summary>
        /// Metode, der returnerer pris på bil
        /// </summary>
        /// <returns>
        /// Returns pris på 240
        /// </returns>
        public override decimal Pris()
        {
            return 240;
        }

        /// <summary>
        /// Metode, der returnerer type af køretøj
        /// </summary>
        /// <returns>
        /// Returns "bil"
        /// </returns>
        public override string TypeKøretøj()
        {
            return "bil";
        }
    }
}