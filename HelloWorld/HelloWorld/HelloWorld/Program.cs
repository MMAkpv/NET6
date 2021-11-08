using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //string name = "Mirek"; //deklaruji promennou typu retezec, priradil jsem text "Mirek"
            
            Console.Write("Jak se jmenuješ: ");
            string name = Console.ReadLine();

            //string pozdrav = "Ahoj " + name;
            string pozdrav = "Ahoj"; //konci strednikem, jeden prikaz

            Console.WriteLine($"{pozdrav} {name}!");

            Console.ReadLine();

        }
    }
}
