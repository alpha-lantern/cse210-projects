public class Journal()
{
    // List of entries for the journal
    public List<Entry> _entries = new List<Entry>();

    // Add a new entry
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    // Display all the journal entries
    public void DisplayAll()
    {
        foreach(Entry entry in _entries) {
            entry.Display();
            Console.WriteLine();
        }
    }

    // Save the journey to a simple file
    public void SaveToFile(string file)
    {
        using (StreamWriter journalFile = new StreamWriter(file))
        {
            foreach(Entry entry in _entries)
            {
                journalFile.WriteLine($"{entry._date}~~{entry._promptText}~~{entry._entryText}");
            }
        }
    }

    // Load from a file
    public void LoadFromFile(string file)
    {
        string[] entry = File.ReadAllLines(file);
        foreach(string line in entry)
        {
            // Create new entry
            Entry newEntry = new();
            // Split the file lines to separate the journal parts
            string[] parts = line.Split("~~");
            // Populate new entry and add it to the list
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            // Add to the entries list
            AddEntry(newEntry);
        }
    }
}