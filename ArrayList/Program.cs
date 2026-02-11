using System;
using System.Collections;
using System.Runtime.Intrinsics.Arm;
public class Program
{
    public static void Main()
    {
        ArrayList list_one = new ArrayList() { 1, 2, 3, 4 };

        ArrayList list = new ArrayList();
        list.Add(1);
        list.Add("Ram");
        list.Add(true);
        list.Add(new Program());
        list.Add(10.4);
        list.Insert(5, "Object");
        list.InsertRange(6, list_one);

        //try
        //{
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        Console.WriteLine(list[i]);
        //    }
          
        //}
        //catch (Exception e)
        //{
        //    {
        //        Console.WriteLine(e.Message);
        //    }


        //}
        //Remove Element
        list.Remove(1);
        list.RemoveAt(6);
        //list.RemoveRange(index, count)
        //list.Clear()


        //Checking Existence
        Console.WriteLine(list.Contains(list_one));
        //shorting arraylist
        try
        {
            list.Sort();
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
        }
        //Clone Arraylist
        ArrayList clonedlist = (ArrayList)list.Clone();
        if(clonedlist != null )
        {
            Console.WriteLine("ClonedList Have Data");
        }
        //Converting ArrayList to Obj

        object[] arr = new object[list.Count];
        list.CopyTo(arr);
        foreach (object obj in arr) 
        {
            Console.WriteLine(obj);
        }
        Console.WriteLine("----------");
        //printing all element
        foreach (var elem in list)
        {
            Console.WriteLine(elem);
        }
    }
}
