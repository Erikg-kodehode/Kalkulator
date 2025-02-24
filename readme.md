# Calculator med klasser, interfacer og metoder

Dette prosjektet er et .NET Console Application som implementerer en enkel kalkulator med bruk av klasser, interfacer og metoder. Kalkulatoren støtter operasjoner som addisjon, subtraksjon, multiplikasjon og divisjon, og all utskrift til konsollen er på norsk.

## Funksjonalitet

- **Addisjon:** Legger sammen to tall.
- **Subtraksjon:** Trekker det andre tallet fra det første.
- **Multiplikasjon:** Multipliserer to tall.
- **Divisjon:** Deler to tall (med sjekk for deling på null).

Kalkulatoren bruker en Regex for å validere brukerinput og tilbyr robust inputvalidering. Ved avslutning av en beregning blir brukeren spurt om de vil fortsette, med støtte for input som `j`, `ja`, `y` eller `yes` (ekstra bokstaver eller symboler blir fjernet).

## Prosjektstruktur

- `ICalculator.cs` - Definerer et interface med kalkulatoroperasjoner.
- `Calculator.cs` - Implementerer `ICalculator` og definerer kalkulatorlogikken.
- `Program.cs` - Hovedprogrammet som håndterer brukerinput og output.

## Komme i gang

### Forutsetninger

- [.NET SDK](https://dotnet.microsoft.com/download) installert på systemet.

### Slik kjører du applikasjonen

1. Åpne terminalen og naviger til prosjektmappen:

   ```bash
   cd calculator_c_sharp
   ```

2. Bygg prosjektet:

   ```bash
   dotnet build
   ```

3. Kjør applikasjonen:
   ```bash
   dotnet run
   ```

## Git Repository

For å opprette og pushe dette prosjektet til et Git-repository med navnet "calculator med klasser interfacer og metoder", kan du bruke følgende kommandoer:

1. Initialiser Git:

   ```bash
   git init
   ```

2. Legg til alle filer:

   ```bash
   git add .
   ```

3. Commit endringene:

   ```bash
   git commit -m "Initial commit: Kalkulator med klasser, interfacer og metoder"
   ```

4. Legg til remote (erstatt `<din-repo-URL>` med URL-en til ditt repository):

   ```bash
   git branch -M main
   git remote add origin <din-repo-URL>
   ```

5. Push til remote:
   ```bash
   git push -u origin main
   ```

## Lisens

Denne koden er lisensiert under [MIT License](LICENSE) (hvis du legger til en lisensfil).

---

God utvikling!
