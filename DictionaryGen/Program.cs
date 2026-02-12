using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        // Dictionary = key‑value pairs
        Dictionary<string, string> countries = new Dictionary<string, string>
        {
            { "UK", "London" },
            { "USA", "Washington" },
            { "IND", "New Delhi" }
        };

        // Adding Elements
        countries.Add("Russia", "Moscow");
        countries["Japan"] = "Tokyo";

        // Accessing Values
        Console.WriteLine("USA - " + countries["USA"]);

        // Iterating with foreach
        Console.WriteLine("\nAll countries (simple iteration):");
        foreach (var item in countries)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nAll countries (KeyValuePair):");
        foreach (KeyValuePair<string, string> kvp in countries)
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");

        // ContainsKey & ContainsValue
        Console.WriteLine("\nCheck existence:");
        Console.WriteLine("Contains key 'UK'? " + countries.ContainsKey("UK"));
        Console.WriteLine("Contains key 'FR'? " + countries.ContainsKey("FR"));
        Console.WriteLine("Contains value 'Tokyo'? " + countries.ContainsValue("Tokyo"));
        Console.WriteLine("Contains value 'Paris'? " + countries.ContainsValue("Paris"));

        // Remove a key
        Console.WriteLine("\nRemoving 'UK'...");
        countries.Remove("UK");

        Console.WriteLine("\nAfter removing 'UK':");
        foreach (var kvp in countries)
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");

        // Clear the dictionary
        Console.WriteLine("\nClearing all entries...");
        countries.Clear();
        Console.WriteLine("Count after Clear(): " + countries.Count);
    }
}
