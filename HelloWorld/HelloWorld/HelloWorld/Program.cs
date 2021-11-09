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
            #region Reseni
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
            #endregion

            //převod teploty ze °F na °C
            #region Reseni
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
            #endregion
            // zadání - dokud jsou zadávána čísla tak se převádí teplota z °F na °C, upraveno dokud zadávám čísla...
            #region Reseni
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
            #endregion
            //s pomocí try-catch
            #region Reseni
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
            #endregion

            //práce se stringy
            #region Stringy
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
            #endregion
            //úkol - načíst jméno a věk, uložit do souboru txt jmeno;věk, vždy nový řádek
            #region Reseni
            /*
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
            */
            #endregion
            //Datum a čas
            #region DatumCas
            /*
            DateTime date = new DateTime(2020, 12, 22, 19, 0, 0);
            Console.WriteLine(date);

            Console.WriteLine(DateTime.Now); //aktuální datum a čas
            Console.WriteLine(DateTime.Now.Date); //pouze datum bez času, resp čas jsou 0

            var twoWeeks = date.AddDays(14); //do nové proměnné jsem přičetl 14 dní k proměnné datem, odečítání adddays se zapornou hodnotou...
            Console.WriteLine(twoWeeks);

            Console.WriteLine(date.Year); //např. jen rok z datumu
            Console.WriteLine(date.ToShortDateString());  //datum do zkráceného formátu, řetězec
            
             */
            #endregion
            // úkol zjistit zda je uživateli 18 a více let
            #region Reseni
            //Console.Write("Zadej datum oddělené tečkami: ");
            //DateTime datum = DateTime.Parse(Console.ReadLine());

            //TimeSpan ts = DateTime.Now - datum;



            //if (ts.TotalDays / 365 >= 18)
            //{
            //    Console.WriteLine("Jsi dospělý");
            //}
            //else
            //{
            //    Console.WriteLine("Nejsi dospělý");
            //}
            #endregion

            // úkol napsat a použít metodu, která spočítá věk
            #region Reseni
            //Console.WriteLine($"Je ti {AgeSolver()} let");
            #endregion

            //úkol napsat a použít metodu, pro spočítání věku
            #region Reseni
            /*
            Console.Write("Zadej a: ");
            int numA = int.Parse(Console.ReadLine());
            Console.Write("Zadej b: ");
            int numB = int.Parse(Console.ReadLine());
            Console.WriteLine($"Větší číslo je {NumComparer(numA, numB)}");
            */
            #endregion

            //úkol napsat a použít metodu, která ověří, jestli jméno končí na ová
            #region Reseni
            //Console.WriteLine(IsEndingOva("Frčková"));
            #endregion

            //úkol ze souboru načíst lidi a zjistit nejstaršího a vypsat ho
            #region Reseni
            //(string, int) vysledek = FindOld("lide.txt");
            //Console.WriteLine($"Nejstarší je {vysledek.Item1}, je mu {vysledek.Item2} let.");
            #endregion
            

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

        /// <summary>
        /// Metoda spočítá a vrátí věk k dnešnímu datu - věk jako ořezaný int
        /// </summary>
        /// <param></param>
        /// <returns>vek as int</returns>
        static int AgeSolver()
        {
            Console.Write("Zadej datum oddělené tečkami: ");
            DateTime datum = DateTime.Parse(Console.ReadLine());

            TimeSpan ts = DateTime.Today - datum;

            return ((int)(ts.TotalDays / 365));

        }

        /// <summary>
        /// Stejné jako předchozí, jen obecněji, lze využít např. ve WPF, protože načtení narození udělám mimo
        /// </summary>
        /// <param name="dateOfBirth"></param>
        /// <returns>vek as int</returns>
        static int AgeSolver(DateTime dateOfBirth)
        {
            TimeSpan ts = DateTime.Today - dateOfBirth;
            return ((int)(ts.TotalDays / 365));
        }

        /// <summary>
        /// Porovná dvě čísla a vrací to větší
        /// </summary>
        /// <param name="numA"></param>
        /// <param name="numB"></param>
        /// <returns>returns higher number</returns>
        static int NumComparer(int numA, int numB)
        {

            //return Math.Max(numA, numB); ///funkcí Max
            //return x > y ? x : y; //ternárním operátorem

            if (numA >= numB)
            {
                return numA;
            }
            else
            {
                return numB;
            }
        }

        /// <summary>
        /// vrací boolean hodnotu, zda zadané příjmení končí na "ová"
        /// </summary>
        /// <param name="name"></param>
        /// <returns>vrací true/false</returns>
        static bool IsEndingOva(string name)
        {
            return name.EndsWith("ová");
        }

        /// <summary>
        /// načte soubor a v něm najde nejstaršího človíčka 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>nejstarší člověk ve formátu (string, int)</returns>
        static (string, int) FindOld(string fileName)
        {
            string[] fileData = File.ReadAllLines(fileName);

            string[] nejstarsi = fileData[0].Split(";");

            foreach (var item in fileData)
            {
                if (int.Parse(item.Split(";")[1]) > int.Parse(nejstarsi[1]))
                {
                    nejstarsi[0] = item.Split(";")[0];
                    nejstarsi[1] = item.Split(";")[1];
                }
            }

            return (nejstarsi[0], int.Parse(nejstarsi[1]));
            

        }


    }
}
