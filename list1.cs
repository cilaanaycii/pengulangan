using System;

class Program
{
    static void Main()
    {
        List<string> siswa = new List<string>();
        siswa.Add("Andi");
        siswa.Add("Budi");
        siswa.Add("Citra");
        siswa.Add("Dodi");
        siswa.Add("Lani");
        foreach (string s in siswa)
        {
            Console.WriteLine(s);
        }
    }
}