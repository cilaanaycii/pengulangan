using System;

class Program
{
    static void Main()
    {
        int i = 1;
        int total = 0;
        while (i <= 10)
        {
            total += i;
            i++;
        }
        Console.WriteLine("Total: " + total);
    }
}