#Dagbok
DagBok � En enkel digital dagbok i C#

 Beskrivning  
**DagBok** �r ett konsolprogram skrivet i C# som l�ter anv�ndaren skriva, visa, s�ka, spara och l�sa dagboksanteckningar.  
Programmet anv�nder en meny i konsolen d�r anv�ndaren kan navigera mellan olika funktioner.  
Alla anteckningar sparas i en JSON-fil (`diary.json`) s� att de finns kvar �ven efter att programmet st�ngts.



 Funktioner  
 Skriva nya dagboksanteckningar  
 Lista alla sparade anteckningar  
 S�ka anteckningar baserat p� datum  
 Spara anteckningar till fil  
 L�sa in anteckningar fr�n fil  



Meny�versikt  

N�r programmet k�rs visas f�ljande meny i konsolen:

DAGBOK - MENY

Skriv ny anteckning

Lista alla anteckningar

S�k anteckning p� datum

Spara till fil

L�s fr�n fil

Avsluta

yaml
Kopiera kod

Alternativbeskrivning:

 Val | Funktion 

| 1| Skapa en ny anteckning med datum och text |
| 2 | Visa alla sparade anteckningar |
| 3 | S�k en anteckning genom att ange datum i formatet `YYYY-MM-DD` |
| 4 | Spara alla anteckningar till en JSON-fil (`diary.json`) |
| 5 | L�s in anteckningar fr�n JSON-filen |
| 6 | Avsluta programmet |



 Filhantering  

Alla dagboksanteckningar sparas i en JSON-fil med namnet "diary.json" i samma mapp som programmet k�rs fr�n.

 Exempel p� sparad fil:
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
Programmet �r byggt med f�ljande tekniker och bibliotek:

C#

.NET (t.ex. .NET 6 eller .NET 8)

System.Text.Json � anv�nds f�r att spara och l�sa JSON-data

System.Globalization � anv�nds f�r att hantera datumformat

 S� k�r du programmet
1?? Klona eller ladda ner projektet
Om du anv�nder Git:

bash
Kopiera kod
git clone https://github.com/<ditt-repo>/DagBok.git
Eller ladda ner projektmappen manuellt.

2?? Bygg och k�r programmet
�ppna projektet i Visual Studio eller VS Code.
K�r programmet genom att trycka p� F5 eller k�r i terminalen med:

bash
Kopiera kod
dotnet run
 Klass�versikt
DiaryEntry
Representerar en enskild dagboksanteckning.

Egenskap	Typ	Beskrivning
Date	DateTime	Datum f�r anteckningen
Text	string	Sj�lva anteckningens text

Program
Inneh�ller programmets huvudlogik och menyhantering.

Viktiga metoder:

Metod	Beskrivning
AddEntry()	L�gger till en ny anteckning
ListEntries()	Visar alla anteckningar
SearchEntry()	S�ker efter anteckningar via datum
SaveToFile()	Sparar anteckningar till diary.json
LoadFromFile()	L�ser in anteckningar fr�n diary.json

 Exempel p� anv�ndning
markdown
Kopiera kod
DAGBOK - MENY
1. Skriv ny anteckning
2. Lista alla anteckningar
3. S�k anteckning p� datum
4. Spara till fil
5. L�s fr�n fil
6. Avsluta
V�lj: 1

Ange datum (����-MM-DD): 2025-10-08
Skriv anteckning: Testar min nya dagbok!
Anteckning sparad!
F�rslag p� vidareutveckling
M�jlighet att redigera eller radera anteckningar

Kryptering av JSON-filen f�r �kad s�kerhet

St�d f�r flera anv�ndare

En grafisk version av programmet med WPF eller MAUI

 F�rfattare
Projektet �r utvecklat som ett �vningsprojekt i C# f�r att �va p�:

Objektorienterad programmering

Filhantering

JSON-serialisering

Menyhantering i konsolapplikationer

