using System;

class Program
{
    static void Main()
    {
        int[] angka = { 1, 2, 3, 4, 5 };
        int terbesar = angka[0];
        foreach (int a in angka)
        {
            if (a > terbesar)
            {
                terbesar = a;
            }
        }
        Console.WriteLine("Angka terbesar adalah: " + terbesar);
    }
}