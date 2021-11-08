using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //pozdrav podle zadaného jména;
            //string name = "Mirek"; //deklaruji promennou typu retezec, priradil jsem text "Mirek"

            //Console.Write("Jak se jmenuješ: ");
            //string name = Console.ReadLine();

            //Hello(name);

            //vytvorte metodu, ktera vstup vynasobi  2 a pricte hodnotu 10

            Console.Write("Zadej hodnotu: ");
            int x = int.Parse(Console.ReadLine()); //vstup x parsuju na typ int
            Console.WriteLine(MyMath(x));

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
        
        /// <summary>
        /// Metoda vrací zadané celé číslo vynásobené 2 a navýšené o  hodnotu 10
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        static int MyMath(int x)
            {
                return ((x * 2) + 10);
            }


    }
}
