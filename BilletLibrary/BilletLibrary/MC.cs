namespace BilletLibrary
{
    /// <inheritdoc />
    /// <summary>
    /// MC klasse, der nedarver fra Køretøj klassen
    /// </summary>
    public class MC : Køretøj
    {
        // public string Nummerplade;
        // public DateTime Dato;

        /// <summary>
        /// Metode, der returnerer MC's pris
        /// </summary>
        /// <returns>
        /// Returns pris på 125
        /// </returns>
        public override decimal Pris()
        {
            return 125;
        }

        /// <summary>
        /// Metode, der returnerer type af køretøj
        /// </summary>
        /// <returns>
        /// Returns "MC"
        /// </returns>
        public override string TypeKøretøj()
        {
            return "MC";
        }
    }
}
