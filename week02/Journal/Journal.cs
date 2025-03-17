using System.IO;
using System.Text.Json;

public class Journal
{

    //Member variables
    public List<Entry> _entries = new List<Entry>();

    //Constructor
    public Journal() { }

    //Methods
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry.PromptText}~~{entry.EntryText}~~{entry.Date}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        try
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                Entry entry = new Entry();
                string[] parts = line.Split("~~");

                entry.PromptText = parts[0];
                entry.EntryText = parts[1];
                entry.Date = parts[2];

                _entries.Add(entry);
            }
        }
        catch (Exception ex)
        {
            Console.Write($"{ex.Message}");
        }
    }

    public void SaveToJsonFile()
    {
        //serialize the list of entry to Json
        string jsonString = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });

        //Save JSON to file
        File.WriteAllText("journal.json", jsonString);
    }


    public void LoadFromJsonFile()
    {
        //Read the JSON from the file
        string jsonFromFile = File.ReadAllText("journal.json");

        //Deserialize JSON from file back to object
        _entries = JsonSerializer.Deserialize<List<Entry>>(jsonFromFile);
    }

}