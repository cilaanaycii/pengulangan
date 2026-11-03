using System;

class Program
{
    static void Main()
    {
        List<string> siswa = new List<string>();
        siswa = new List<string> { "Andi", "Budi", "Citra", "Dodi", "Lani" };

        siswa.Remove("Andi");
        siswa.RemoveAt(0);
        Console.WriteLine("Isi List Siswa setelah dihapus:");
        foreach (string s in siswa)
        {
            Console.WriteLine(s);
        }
    }
}