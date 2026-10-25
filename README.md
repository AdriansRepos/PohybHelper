# PohybHelper

Sdílené základní typy pro evidenci pohybů (skladových, pokladních, finančních) napříč aplikacemi.

## Obsah

### Rozhraní `IPohyb`
Společné rozhraní pro libovolný typ pohybu, umožňující jednotné řazení, filtrování a výpis napříč různými oblastmi evidence (např. propojení denní uzávěrky pokladny s účetnictvím).

```csharp
public interface IPohyb
{
    DateTime DatumCas { get; }
    string Popis();
}
```

### Výčtové typy
- `SkladovyTypPohybu` – Naskladnění, Vyskladnění
- `PokladniTypPohybu` – Prodej, Storno
- `FinancniTypPohybu` – Příjem, Výdej

Každý typ lze implementovat samostatně, nezávisle na `IPohyb`, i jako součást vlastní třídy implementující `IPohyb`.

### `PopiskyHelper`
Čte atribut `[Description]` u hodnot výčtového typu a vrací čitelný, česky psaný popisek pro zobrazení v menu. Použitelné i samostatně, nezávisle na zbytku knihovny.

```csharp
PopiskyHelper.ZiskejPopisek(PokladniTypPohybu.Prodej)  // "Prodej"
```

## Instalace jako NuGet balíček

Tato knihovna je dostupná také jako balíček v **GitHub Packages**. Můžete si ji snadno přidat do svého projektu:

1. Nastavte si jako zdroj balíčků váš GitHub (pokud ho ještě nemáte v NuGet.config).
2. V **Package Manager Console** spusťte příkaz:
   ```powershell
   Install-Package BarevneVypisyHelper
   ```
