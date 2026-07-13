using System.ComponentModel;

namespace PohybHelper
{
    /// <summary>
    /// Poskytuje čitelné, česky psané popisky pro hodnoty výčtových
    /// typů (enum) na základě atributu <see cref="DescriptionAttribute"/>.
    /// </summary>
    public static class PopiskyHelper
    {
        /// <summary>
        /// Vrátí text z atributu [Description] přiřazeného dané hodnotě
        /// výčtu. Pokud atribut chybí, vrátí výchozí název hodnoty
        /// (výsledek ToString()).
        /// </summary>
        /// <typeparam name="TEnum">Typ výčtu.</typeparam>
        /// <param name="hodnota">Konkrétní hodnota výčtu.</param>
        /// <returns>Čitelný popisek hodnoty.</returns>
        public static string ZiskejPopisek<TEnum>(TEnum hodnota) where TEnum : struct, Enum
        {
            var pole = typeof(TEnum).GetField(hodnota.ToString());
            var atribut = pole?.GetCustomAttributes(typeof(DescriptionAttribute), false)
                .FirstOrDefault() as DescriptionAttribute;

            return atribut?.Description ?? hodnota.ToString();
        }
    }
}
