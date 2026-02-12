using System;
class Program
{
    public static void Main(string[] args)
    {
        int a = 1;
        int b = 2;
        Console.WriteLine(Calculator.Add(a,b));
        
    }

}
class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}