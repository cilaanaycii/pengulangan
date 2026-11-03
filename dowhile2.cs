using System;

class Program
{
    static void Main()
    {
        string password;
        do
        {
           Console.Write("Masukkan password: ");
            password = Console.ReadLine();
            Console.Clear();
        } while (password != "2521");
        Console.WriteLine("Password benar!");
    }
}