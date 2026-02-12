using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        // HashSet<T> = only unique elements
        HashSet<string> countries = new HashSet<string>()
        {
            "INDIA",
            "USA",
            "UK"
        };

        // Add elements
        countries.Add("Japan");   // added
        countries.Add("USA");     // ignored because duplicate

        // Remove element
        countries.Remove("USA");  // removes USA

        // Count
        Console.WriteLine("Count: " + countries.Count);

        // Check existence
        Console.WriteLine("Contains 'UK'? " + countries.Contains("UK"));
        Console.WriteLine("Contains 'USA'? " + countries.Contains("USA"));

        // FirstOrDefault
        Console.WriteLine("First match 'USA': " + countries.FirstOrDefault(x => x == "USA")); // null if not found
        Console.WriteLine("First match 'INDIA': " + countries.FirstOrDefault(x => x == "INDIA")); // INDIA

        // Iterating
        Console.WriteLine("\nAll countries:");
        foreach (var country in countries)
        {
            Console.WriteLine(country);
        }

        // Set operations example
        HashSet<string> otherCountries = new HashSet<string>() { "China", "India", "Japan" };
        countries.UnionWith(otherCountries); // add unique elements from otherCountries

        Console.WriteLine("\nAfter UnionWith:");
        foreach (var country in countries)
        {
            Console.WriteLine(country);
        }

        countries.IntersectWith(otherCountries); // keep only elements present in otherCountries
        Console.WriteLine("\nAfter IntersectWith:");
        foreach (var country in countries)
        {
            Console.WriteLine(country);
        }

        // Clear
        //countries.Clear();
        Console.WriteLine("\nCount after Clear(): " + countries.Count);
    }
}
