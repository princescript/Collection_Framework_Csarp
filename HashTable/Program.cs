using System;
using System.Collections;
using System.Threading.Channels;
public class Program
{
    public static void Main(string[] args)
    {

        //Creating Hashtable
        Hashtable cities = new Hashtable()
        {
            {"USA","NEWYORK"},
            {"UK", "London"},
            {"India", "Mumbai"}
        };
        cities.Add("Russia", "Moscow");

        //Accessing Elements
        Console.WriteLine(cities["USA"]);

        //Using foreact
        foreach(var key in cities.Keys)
        {
            Console.WriteLine(cities[key]);
        }

        //Checking Existence
        Console.WriteLine(cities.ContainsKey("USA"));
        Console.WriteLine(cities.ContainsValue("Mumbai"));

        //Removing Items
        cities.Remove("USA");
        cities.Clear();

    }

}