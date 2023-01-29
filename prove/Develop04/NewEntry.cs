using System;

class NewEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }

    public NewEntry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now;
    }
}