using System;
using System.Collections;
class Program
{
    public static void Main(string[] args)
    {
        //FIFO = Queue
        Queue queue = new Queue();
        queue.Enqueue(1);
        queue.Enqueue("Ram");
        queue.Enqueue(4.44);
        queue.Enqueue(new Program());

        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("-------");

        //Removing Elements
        queue.Dequeue();

        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        //Peek
        Console.WriteLine(queue.Peek());

        Console.WriteLine("-------");

        //Clone
        Queue queue1 = (Queue)queue.Clone();
        if(queue1 != null) Console.WriteLine("queue1 have cloned data");

        //Count
        queue.Clear();
        Console.WriteLine(queue.Count);

        //Contains
        Console.WriteLine(queue.Contains("Ram"));//false

    }
}