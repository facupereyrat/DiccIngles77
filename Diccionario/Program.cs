using System;
using System.Collections.Generic;

class SimpleDictionary
{
    private SortedList<string, string> words;

    public SimpleDictionary()
    {
        words = new SortedList<string, string>();
    }

    public void AddWord(string word, string definition)
    {
        words[word] = definition;
    }

    public string GetDefinition(string word)
    {
        if (words.TryGetValue(word, out var definition))
        {
            return definition;
        }
        return "Word not found.";
    }

    public void Display()
    {
        foreach (var kvp in words)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        SimpleDictionary dictionary = new SimpleDictionary();
        dictionary.AddWord("apple", "A fruit that is usually red or green.");
        dictionary.AddWord("banana", "A long yellow fruit.");
        dictionary.AddWord("cherry", "A small round fruit that is typically red.");

        // Mostrar el diccionario
        dictionary.Display();

        // Obtener la definición de una palabra
        Console.WriteLine(dictionary.GetDefinition("banana"));
    }
}
