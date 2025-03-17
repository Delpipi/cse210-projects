using System.Text.Json.Serialization;

public class Entry
{

    //Properties
    [JsonPropertyName("date")]
    public string Date { get; set; } = "";
    //public string _date = "";

    [JsonPropertyName("promptText")]
    public string PromptText { get; set; } = "";
    //public string _promptText = "";

    [JsonPropertyName("entryText")]
    public string EntryText { get; set; } = "";
    //public string _entryText = "";

    //Constructor
    public Entry() { }

    //Methods
    public void Display()
    {
        Console.WriteLine($"Date: {Date} - Prompt: {PromptText}");
        Console.WriteLine($"{EntryText}");
    }
}