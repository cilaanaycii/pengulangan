using System;

class Program
{
    static void Main()
    {
        int[] angka = { 1, 5, 7, 3, 2, 0, 9, 4, 6, 8 };
        Array.Sort(angka);
        foreach (int n in angka)
        {
            Console.WriteLine(n);
        }
    }
}