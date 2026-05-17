using System.IO; 
class Journal
{
    public List<Entry> _entries=new List<Entry>();

    public void AddEntry()
    {
        Entry entry = new Entry();

        entry._date = entry.GetDate();
        entry._prompt = entry.GetPrompt();

        Console.WriteLine(entry._prompt);
        Console.WriteLine(">>> ");
        entry._response = Console.ReadLine();

        _entries.Add(entry);
    }
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void Save()
    {
        System.Console.Write("Name of saving file");
        Console.WriteLine(">>> ");
        string filename=Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}\n");
            }
        }
    }
    public void Load()
    {
        System.Console.Write("Name of file to load");
        Console.WriteLine(">>> ");
        string filename=Console.ReadLine();

        if (!File.Exists(filename))
            return;

        string[] lines = File.ReadAllLines(filename);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            if (parts.Length == 3)
            {
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._prompt = parts[1];
                entry._response = parts[2];

                _entries.Add(entry);
            }
        }
    }
}