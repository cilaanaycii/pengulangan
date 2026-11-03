using System;

class Program
{
    static void Main()
    {
        int[] angka = { 76, 98, 78, 87, 100 };
        Array.Sort(angka);
        foreach (int n in angka)
        {
            Console.WriteLine(n);
        }
    }
}