class Journal
{
    private List<NewEntry> entries = new List<NewEntry>();
    private PromptGenerator promptGenerator;

    public Journal()
    {
        promptGenerator = new PromptGenerator();
    }

    public void WriteNewEntry()
    {
        var prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        var response = Console.ReadLine();
        entries.Add(new NewEntry(prompt, response));
    }

    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine("Prompt: " + entry.Prompt);
            Console.WriteLine("Response: " + entry.Response);
            Console.WriteLine("Date: " + entry.Date);
        }
    }

    public void SaveJournal(string filename)
{
    using (var writer = new StreamWriter(File.Create(filename)))
    {
        foreach (var entry in entries)
        {
            string entryData = string.Join("~", entry.Prompt, entry.Response, entry.Date);
            writer.WriteLine(entryData);
        }
    }
}

    public void LoadJournal(string filename)
    {
        entries.Clear();
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] entryData = line.Split('~');
                var entry = new NewEntry(entryData[0], entryData[1]);
                entry.Date = DateTime.Parse(entryData[2]);
                entries.Add(entry);
            }
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }
}
