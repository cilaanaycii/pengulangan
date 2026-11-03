using System;

class Program
{
    static void Main()
    {
        int angka, total = 0;
        do
        {
            Console.Write("Masukkan angka (Masukkan Angka 0 untuk berhenti): ");
            angka = int.Parse(Console.ReadLine());
            total += angka;
        } while (angka != 0);
        Console.WriteLine("Total: " + total);
    }
}