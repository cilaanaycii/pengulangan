using System;

class Program
{
    static void Main()
    {
        int[] angka = { 76, 98, 76, 87, 100 };
        int total = 0;
        for (int i = 0; i < angka.Length; i++)
        {
            total += angka[i];
        }
        Console.WriteLine("Total: " + total);
    }
}