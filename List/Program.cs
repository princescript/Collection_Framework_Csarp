using System;

class Program
{
    public static void Main(String[] args)
    {
        List<string> list = new List<string>()
        {
            "India",
            "Usa",
            "Russia",
            "Franch"
        };
        //Add
        list.Add("Dubai");

        //ForEach Loop
        list.ForEach(x => Console.WriteLine(x));


        //Accessing and Inserting Items

        list.Insert(5, "Africa");

        //Remove
        list.Remove("Usa");
        list.RemoveAt(0);

        list.RemoveRange(0, 2);
        //list.Clear();

        //Add Range
        list.AddRange(new List<string> {"TT","GG" });

        //ForLoop
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);

        }

        //copy a array to list 
        int[] arr = { 1, 2, 3 };
        List<int> copiedfromArr = new List<int>(arr);
        copiedfromArr.ForEach(x => Console.WriteLine(x));

        //contains
        Console.WriteLine(list.Contains("TT"));

        Console.WriteLine("-----------------------");

        //sort()
        list.Sort();
        list.ForEach(x => Console.WriteLine(x));

        Console.WriteLine("-----------------------");
        //Reverse()
        list.Reverse();
        list.ForEach(x => Console.WriteLine(x));

        Console.WriteLine("-----------------------");
        //Finding Elements
        Console.WriteLine("firstmatchvalue " + copiedfromArr.Find(x => x == 20));

        Console.WriteLine("allvalue > 0 " +
            string.Join(", ", copiedfromArr.FindAll(x => x > 0)));

        Console.WriteLine("findlast " + copiedfromArr.FindLast(x => x == 3));

        Console.WriteLine("index of elem " + copiedfromArr.FindIndex(x => x == 2));

        Console.WriteLine("check elem existence " + copiedfromArr.Exists(x => x == 1));
    }
    }