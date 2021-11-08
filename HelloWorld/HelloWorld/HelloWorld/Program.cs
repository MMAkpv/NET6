using System;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //pozdrav podle zadaného jména;
            //string name = "Mirek"; //deklaruji promennou typu retezec, priradil jsem text "Mirek"

            /*
            Console.Write("Jak se jmenuješ: ");
            string name = Console.ReadLine();

            Hello(name);
            */

            //vytvorte metodu, ktera vstup vynasobi  2 a pricte hodnotu 10

            /*
            Console.Write("Zadej hodnotu: ");
            int x = int.Parse(Console.ReadLine()); //vstup x parsuju na typ int
            Console.WriteLine(MyMath(x));
            */


            //převod teploty ze °F na °C

            /*
            ConvertFtoCAndPrint();
            */


            //while
            /*
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i += 1;
            }

            Console.ReadLine();
            */

            // zadání - dokud jsou zadávána čísla tak se převádí teplota z °F na °C, upraveno dokud zadávám čísla...
            /*
            while (true)
            {
                Console.Write("Zadej teplotu ve °F: ");
                string input = Console.ReadLine();
                if (double.TryParse(input, out  double inputDouble))
                    Console.WriteLine($"To je {TempConversion(inputDouble)}°C");
                else
                {
                    break;
                }
            }
            */

            //s pomocí try-catch

            /*
            while (true)
            {
                Console.Write("Zadej teplotu ve °F: ");
                string input = Console.ReadLine();
                try
                {
                    Console.WriteLine($"To je {TempConversion(double.Parse(input))}°C");
                }
                catch (Exception e)
                {
                    if (input != "x") //x beru jako standardní zavření a neloguju jej, ostatní nekonvertovatelné vstupy jako chyby...
                    {
                        File.AppendAllText("errorlog.txt",e.Message + Environment.NewLine);
                        Console.WriteLine("Chyba, podívej se do errorlogu!");
                    }
                    else
                    {
                        break;
                    }
                    
                }
            
            }
            */

            //práce se stringy

            /*
            string name = "MirEk Malaga";

            Console.WriteLine(string.IsNullOrEmpty(name)); //zjišťuji, jestli je null nebo prázdný string

            if(!string.IsNullOrEmpty(name)) //když není null, nebo prázdný string
            {
                Console.WriteLine(name);
            }
            else
            {
                Console.WriteLine("nemá jméno");
            }

            Console.WriteLine(name.Length); //délka hodnoty v proměnné name
            Console.WriteLine(name.Trim()); //odstranění prázdných znaků na začátku a konci stringu, dělá nový string, nepřepisuje původní :)

            string[] items = name.Split(" "); //rozdělím si string do pole
            Console.WriteLine($"jméno: {items[0]}");
            Console.WriteLine($"příjmení: {items[1]}");

            Console.WriteLine(name.Contains("Mirek")); //hledám podřetězec v řetězci, vrací true/false
            Console.WriteLine(name.Contains("miRek", StringComparison.OrdinalIgnoreCase)); //to samé jako předchozí bez ohledu na velikost písmen, vrací true/false
            Console.WriteLine(name.ToLower()); //převedu text na malá písmena

            Console.WriteLine(name.Substring(5, 6)); //substring :), od pozice, počet znaků - ne do pozice! čti nápovědu :D

            */

            //úkol - načíst jméno a věk, uložit do souboru txt jmeno;věk, vždy nový řádek

            while (true)
            {
                Console.Write("Zadej jméno, x ukončí app: ");
                string jmeno = Console.ReadLine();

                if (jmeno == "x")
                {
                    break;
                }

                Console.Write("Zadej věk: ");
                string vek = Console.ReadLine();

                try
                {
                    File.AppendAllText("users.txt", $"{jmeno};{vek}"+Environment.NewLine);
                }
                catch (Exception e)
                {
                        File.AppendAllText("errorlog.txt", e.Message + Environment.NewLine);
                        Console.WriteLine("Chyba, podívej se do errorlogu!");
                }


            }


                Console.ReadKey();

        }

        /// <summary>
        /// metoda použije metodu pro převod teplot ze °F na °C a výsledek vytiskne do konzole
        /// </summary>
        private static void ConvertFtoCAndPrint()
        {
            Console.Write("Zadej teplotu ve °F: ");
            double fTemp = double.Parse(Console.ReadLine());
            Console.WriteLine($"{fTemp}°F je {TempConversion(fTemp)}°C");
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

        /// <summary>
        /// Metoda prevede teplotu ze °F ma °C a vrati vysledek
        /// </summary>
        /// <param name="FTemp"></param>
        /// <returns></returns>
        static double TempConversion(double fTemp)
        {
            double cTemp = (fTemp - 32) / 1.8;
            return cTemp;
        }

    }
}
