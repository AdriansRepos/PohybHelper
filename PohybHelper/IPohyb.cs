namespace PohybHelper
{
    /// <summary>
    /// Společné rozhraní pro skladové, finanční a pokladní pohyby, umožňující
    /// jednotné řazení, výpis a případné provázání mezi oblastmi
    /// (např. denní uzávěrka pokladny se promítne jako příjem
    /// v hotovostní pokladně účetnictví).
    /// </summary>
    public interface IPohyb
    {
        /// <summary>
        /// Datum a čas, kdy k pohybu došlo.
        /// </summary>
        DateTime DatumCas { get; }

        /// <summary>
        /// Vrátí stručný textový popis pohybu pro výpis do konzole.
        /// </summary>
        string Popis();
    }
}
