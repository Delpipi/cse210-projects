using System.Text.Json.Serialization;

public class Entry
{

    //Properties
    [JsonPropertyName("date")]
    public string Date { get; set; } = "";

    [JsonPropertyName("promptText")]
    public string PromptText { get; set; } = "";

    [JsonPropertyName("entryText")]
    public string EntryText { get; set; } = "";

    //Constructor
    public Entry() { }

    //Methods
    public void Display()
    {
        Console.WriteLine($"Date: {Date} - Prompt: {PromptText}");
        Console.WriteLine($"{EntryText}");
    }
}