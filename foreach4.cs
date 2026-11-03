using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        int[] nilai = { 70, 80,90, 100 };
        int total = 0;
        foreach (int a in nilai)
        {
            total += a;
        }
        Console.WriteLine("Total: " + total);
    }
}