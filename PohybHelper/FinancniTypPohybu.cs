using System.ComponentModel;

namespace PohybHelper
{
    /// <summary>
    /// Typ finančního pohybu v hotovostní pokladně účetnictví.
    /// </summary>
    public enum FinancniTypPohybu
    {
        [Description("Příjem")]
        Prijem,

        [Description("Výdej")]
        Vydej
    }
}