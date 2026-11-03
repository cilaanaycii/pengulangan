using System;

class Program
{
    static void Main()
    {
        List<string> jajanJadul = new List<string>();
        jajanJadul.Add("Serabi");
        jajanJadul.Add("Kue Kucur");
        jajanJadul.Add("Bakpia");
        jajanJadul.Add("Cakwe");
        jajanJadul.Add("Jemblem");
        foreach (string s in jajanJadul)
        {
            Console.WriteLine(s);
        }
    }
}