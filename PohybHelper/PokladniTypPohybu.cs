using System.ComponentModel;

namespace PohybHelper
{
    /// <summary>
    /// Typ pokladního pohybu při prodeji vstupenek.
    /// </summary>
    public enum PokladniTypPohybu
    {
        [Description("Prodej")]
        Prodej,

        [Description("Storno")]
        Storno
    }
}