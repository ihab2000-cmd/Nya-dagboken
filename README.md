#Dagbok
DagBok – En enkel digital dagbok i C#

 Beskrivning  
**DagBok** är ett konsolprogram skrivet i C# som låter användaren skriva, visa, söka, spara och läsa dagboksanteckningar.  
Programmet använder en meny i konsolen där användaren kan navigera mellan olika funktioner.  
Alla anteckningar sparas i en JSON-fil (`diary.json`) så att de finns kvar även efter att programmet stängts.



 Funktioner  
 Skriva nya dagboksanteckningar  
 Lista alla sparade anteckningar  
 Söka anteckningar baserat på datum  
 Spara anteckningar till fil  
 Läsa in anteckningar från fil  



Menyöversikt  

När programmet körs visas följande meny i konsolen:

DAGBOK - MENY

Skriv ny anteckning

Lista alla anteckningar

Sök anteckning på datum

Spara till fil

Läs från fil

Avsluta

yaml
Kopiera kod

Alternativbeskrivning:

 Val | Funktion 

| 1| Skapa en ny anteckning med datum och text |
| 2 | Visa alla sparade anteckningar |
| 3 | Sök en anteckning genom att ange datum i formatet `YYYY-MM-DD` |
| 4 | Spara alla anteckningar till en JSON-fil (`diary.json`) |
| 5 | Läs in anteckningar från JSON-filen |
| 6 | Avsluta programmet |



 Filhantering  

Alla dagboksanteckningar sparas i en JSON-fil med namnet "diary.json" i samma mapp som programmet körs från.

 Exempel på sparad fil:
 json
[
  {
    "Date": "2025-10-08T00:00:00",
    "Text": "Idag startade jag min digitala dagbok!"
  },
  {
    "Date": "2025-10-09T00:00:00",
    "Text": "Det fungerar perfekt!"
  }
]
 Tekniker och bibliotek
Programmet är byggt med följande tekniker och bibliotek:

C#

.NET (t.ex. .NET 6 eller .NET 8)

System.Text.Json – används för att spara och läsa JSON-data

System.Globalization – används för att hantera datumformat

 Så kör du programmet
1?? Klona eller ladda ner projektet
Om du använder Git:

bash
Kopiera kod
git clone https://github.com/<ditt-repo>/DagBok.git
Eller ladda ner projektmappen manuellt.

2?? Bygg och kör programmet
Öppna projektet i Visual Studio eller VS Code.
Kör programmet genom att trycka på F5 eller kör i terminalen med:

bash
Kopiera kod
dotnet run
 Klassöversikt
DiaryEntry
Representerar en enskild dagboksanteckning.

Egenskap	Typ	Beskrivning
Date	DateTime	Datum för anteckningen
Text	string	Själva anteckningens text

Program
Innehåller programmets huvudlogik och menyhantering.

Viktiga metoder:

Metod	Beskrivning
AddEntry()	Lägger till en ny anteckning
ListEntries()	Visar alla anteckningar
SearchEntry()	Söker efter anteckningar via datum
SaveToFile()	Sparar anteckningar till diary.json
LoadFromFile()	Läser in anteckningar från diary.json

 Exempel på användning
markdown
Kopiera kod
DAGBOK - MENY
1. Skriv ny anteckning
2. Lista alla anteckningar
3. Sök anteckning på datum
4. Spara till fil
5. Läs från fil
6. Avsluta
Välj: 1

Ange datum (ÅÅÅÅ-MM-DD): 2025-10-08
Skriv anteckning: Testar min nya dagbok!
Anteckning sparad!
Förslag på vidareutveckling
Möjlighet att redigera eller radera anteckningar

Kryptering av JSON-filen för ökad säkerhet

Stöd för flera användare

En grafisk version av programmet med WPF eller MAUI

 Författare
Projektet är utvecklat som ett övningsprojekt i C# för att öva på:

Objektorienterad programmering

Filhantering

JSON-serialisering

Menyhantering i konsolapplikationer

