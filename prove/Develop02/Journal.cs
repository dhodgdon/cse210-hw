using System;
using System.IO;

public class Journal
{
    public List<Entry> _journals = new List<Entry>();

    public string _saveFileName;
    public string _loadFileName;

    public void DisplayEntries()
    {
        
        foreach (Entry _journal in _journals)
        {
            // Console.WriteLine(_journal.CompileEntry());
            _journal.DisplayEntry();
        }

    }
    public void SaveToFile(string file)
    {
        using (StreamWriter journalFile = new StreamWriter(file))
        {
            foreach (Entry _journal in _journals)
            {
                journalFile.WriteLine($"{_journal._dateString}|{_journal._timeString}|{_journal._prompt}|{_journal._entry}");
            }
        }
    }
    
    public Journal LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        Journal loadJournal = new Journal();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();

            entry._dateString = parts[0];
            entry._timeString = parts[1];
            entry._prompt = parts[2];
            entry._entry = parts[3];
            loadJournal._journals.Add(entry);
        }
        return loadJournal;
    }
}