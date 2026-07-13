using System.ComponentModel;

namespace PohybHelper
{
    /// <summary>
    /// Typ skladového pohybu.
    /// </summary>
    public enum SkladovyTypPohybu
    {
        [Description("Naskladnění")]
        Naskladneni,

        [Description("Vyskladnění")]
        Vyskladneni
    }
}