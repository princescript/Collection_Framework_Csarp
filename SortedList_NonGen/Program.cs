using System;
using System.Collections;
class Program
{
    public static void Main(string[] args)
    {
        //ShortedList = key/value pairs
        SortedList sortedList = new SortedList()
        {
            { "Ind", "India" },
            { "USA", "United States" }
        };
        //Adding
        sortedList.Add("Russia", "Moscow");

        //Clone
        SortedList cloneList = (SortedList)sortedList.Clone();
        if(cloneList != null) Console.WriteLine("clone have data");

        //Remove
        sortedList.Remove("USA");
        //sortedList.RemoveAt("index");
        //sortedList.Clear();

        //Checking
        Console.WriteLine(sortedList.ContainsKey("USA"));
        Console.WriteLine(sortedList.ContainsValue("Moscow"));

        //
        foreach (var item in  sortedList)
        {
            Console.WriteLine(item);
        }

    }
}