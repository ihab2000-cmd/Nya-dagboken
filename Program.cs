using System.Globalization;
using System.Text.Json;

namespace DagBok
{






    public class DiaryEntry
    {
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }

    class Program
    {
        static List<DiaryEntry> entries = new List<DiaryEntry>();

        static void Main(string[] args)
        {
            while (true)// här skapade jag menyn
            {
                Console.WriteLine("\n DAGBOK - MENY");
                Console.WriteLine("1. Skriv ny anteckning");
                Console.WriteLine("2. Lista alla anteckningar");
                Console.WriteLine("3. Sök anteckning på datum");
                Console.WriteLine("4. Spara till fil");
                Console.WriteLine("5. Läs från fil");
                Console.WriteLine("6. Avsluta");
                Console.Write("Välj: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": //Lade till meny med switch sats för att hantera användarval i dagboksprogrammet
                        AddEntry();
                        break;
                    case "2":
                        ListEntries();
                        break;
                    case "3":
                        SearchEntry();
                        break;
                    case "4":
                        SaveToFile();
                        break;
                    case "5":
                        LoadFromFile();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine(" Ogiltigt val. Försök igen.");
                        break;
                }

            }
        }

        static void AddEntry()
        {
            Console.Write("Ange datum (ÅÅÅÅ-MM-DD): "); // //Lade till funktioner för att skapa och lista dagboksanteckningar
            string dateInput = Console.ReadLine();

            if (!DateTime.TryParseExact(dateInput, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                Console.WriteLine(" Ogiltigt datumformat!");
                return;
            }

            Console.Write("Skriv anteckning: ");
            string text = Console.ReadLine();

            var entry = new DiaryEntry { Date = date, Text = text };
            entries.Add(entry);

            Console.WriteLine(" Anteckning sparad!");
        }

        static void ListEntries()
        {
            if (entries.Count == 0)
            {
                Console.WriteLine(" Inga anteckningar.");
                return;
            }

            Console.WriteLine("\nAlla anteckningar:");
            foreach (var entry in entries)
            {
                Console.WriteLine($"{entry.Date:yyyy-MM-dd} - {entry.Text}");
            }
        }

        static void SearchEntry()
        {
            Console.Write("Ange datum att söka (ÅÅÅÅ-MM-DD): "); 
            string dateInput = Console.ReadLine();

            if (!DateTime.TryParseExact(dateInput, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                Console.WriteLine(" Ogiltigt datumformat!");
                return;
            }

            bool found = false;
            foreach (var entry in entries)
            {
                if (entry.Date == date)
                {
                    Console.WriteLine($" Hittad: {entry.Date:yyyy-MM-dd} - {entry.Text}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine(" Ingen anteckning för detta datum.");
            }
        }

        static void SaveToFile()
        {
            try
            {  
                string json = JsonSerializer.Serialize(entries, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText("diary.json", json);
                Console.WriteLine(" Anteckningar sparade till fil!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fel vid sparning: {ex.Message}");
            }
        }

        static void LoadFromFile()
        {
            try
            {
                if (!File.Exists("diary.json")) // Lade till metod för att spara dagboksanteckningar till JSON fil
                {
                    Console.WriteLine(" Filen finns inte.");
                    return;
                }

                string json = File.ReadAllText("diary.json");
                var loadedEntries = JsonSerializer.Deserialize<List<DiaryEntry>>(json);

                if (loadedEntries == null)
                {
                    Console.WriteLine("Filen innehåller ogiltig data.");
                    return;
                }

                entries = loadedEntries;

                Console.WriteLine(" Anteckningar inlästa från fil!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Fel vid inläsning: {ex.Message}");
            }
        }


    }
}
