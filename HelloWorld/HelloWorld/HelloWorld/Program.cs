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

            Hello(name);

            Console.ReadLine();

        }

        static void Hello(string name)
        {
            string nameOsloveni = "";

            if (name == "Mirek")
            {
                nameOsloveni = "Mirku";
            }
            else if (name == "Karel")
            {
                nameOsloveni = "Karle";
            }
            else
            {
                nameOsloveni = name;
            }

            //string pozdrav = "Ahoj " + name;
            string pozdrav = "Ahoj"; //konci strednikem, jeden prikaz

            Console.WriteLine($"{pozdrav} {nameOsloveni}!");



        }
    }
}
