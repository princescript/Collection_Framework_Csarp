using System;
using System.Collections;
class Program
{
    public static void Main(string[] args)
    {
        //LIFO
        Stack st = new Stack();
        st.Push(10);
        st.Push("Ram");
        st.Push(4.44);
        st.Push(new Program());

        //For Each loop
        foreach (var item in st)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("------");
        //Remove top element
        st.Pop();

        //Look at top element
        Console.WriteLine(st.Peek()); //4.44

        //Checks if element exists.
        Console.WriteLine(st.Contains(new Program())); //false
    }
}