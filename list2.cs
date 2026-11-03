using System;

class Program
{
    static void Main()
    {
        List<string> pelajaran = new List<string>();
        pelajaran.Add("PKN");
        pelajaran.Add("Matematika");
        pelajaran.Add("Bahasa Indonesia");
        pelajaran.Add("IPA");
        pelajaran.Add("IPS");
        foreach (string s in pelajaran)
        {
            Console.WriteLine(s);
        }
    }
}