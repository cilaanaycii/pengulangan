using System;

class Program
{
    static void Main()
    {
        string[] buah = { "apel", "jeruk", "mangga", "pisang", "anggur", "durian", "rambutan" };
        Console.Write("Cari buah: ");

        string cari = Console.ReadLine();
        bool ditemukan = false;

        for (int i = 0; i < buah.Length; i++)
        {
            if (buah[i].ToLower() == cari.ToLower())
            {
                Console.WriteLine("Buah ditemukan di indeks: " + i);
                ditemukan = true;
                break;
            }
        }

        if (!ditemukan)
        {
            Console.WriteLine("Buah tidak ditemukan.");
        }
    }
}