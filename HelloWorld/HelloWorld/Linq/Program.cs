using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] numbers = { 1, 2, -30, 4, 20, 256, -45, 99 };

            //where filtruje kolekci na cisla >= 0
            #region Where
            /*
            var result = numbers.Where(number => number >= 0);
            //filtruju kolekci na cisla >= nez 0 a <= 100
            var result0_100 = numbers.Where(n => n > 0 && n < 100);
            //to same jako predchozi, jen jiny zapis, napr. pro delsi podminky kvůli citelnosti
            var result0_100_x = numbers
                .Where(n => n >= 0)
                .Where(n => n <= 100);

            foreach (var item in result0_100_x)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

            //orderby - razeni
            #region OrderBy
            /*
            var result = numbers.OrderBy(n => n);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

            //Take a Skip vynechavani a preskakovani
            #region TakeSkip
            /*
            var result = numbers.Take(5); //vezmu prvnich 5 cisel

            var resultSkip = numbers.Skip(3); //preskocim prvni 3 cisla

            //SkipWhile, nebo TakeWhile umozni preskocit s podminkou
            var resultSkipWhile = numbers.SkipWhile(n => n > 0); //preskakuje do prvniho cisla, kde podminka neplati
            var resultTakeWhile = numbers.TakeWhile(n => n > 0); //bere dokud nenarazi na prvni cislo, ktere nesplnuje podminku

            foreach (var item in resultTakeWhile)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

            //Sum, Max, Min, Average, First, Last,... dalsi fce
            #region Sum_a_dalsi
            /*
            var resultSum = numbers.Sum(); //suma cisel, vraci int, stejne by slo pouzit napr. Max, Min, Average

            var resultFirst = numbers.First(); //vypsani prvniho prvku, pomoci Last() lze vypsat posledni prvek

            Console.WriteLine(resultSum);
            Console.WriteLine(resultFirst);
            */
            #endregion


            //Samostatná práce
            #region Zadani_reseni
            /*
            int[] numbers = { -2079, -498, 2920, -1856, 332, -2549, -674, -120, -992, 2782, 320, -524, 135, 952, 1868, 2509, -230, -138, -904, -480 };

            /// z "numebers" zjistěte:
            /// 1. počet prvků v poli
            var pocet = numbers.Count();
            Console.WriteLine($"Počet: {pocet}");
            /// 2. největší hodnotu
            var maximum = numbers.Max();
            Console.WriteLine($"Maximum: {maximum}");
            /// 3. nejmenší hodnotu
            var minimum = numbers.Min();
            Console.WriteLine($"Minimum: {minimum}");
            /// 4. průměr
            var prumer = numbers.Average();
            Console.WriteLine($"Prumer: {prumer}");
            /// 5. kolik obsahuje pole kladných čísel
            //var pocetKladnych = numbers.Where(n => n >= 0).Count();
            var pocetKladnych = numbers.Count(n => n >= 0); //taky možnost zápisu
            Console.WriteLine($"pocet kladnych: {pocetKladnych}");
            /// 6. kolik obsahuje pole záporných čísel
            var pocetZapornych = numbers.Where(n => n < 0).Count();
            Console.WriteLine($"pocet zapornych: {pocetZapornych}");
            /// 7. sumu všech hodnot
            var sumaVsech = numbers.Count();
            Console.WriteLine($"Suma: {sumaVsech}");
            /// 8. sumu kladných hodnot
            var sumaKladnych = numbers.Where(n => n > 0).Sum();
            Console.WriteLine($"Suma kladnych: {sumaKladnych}");
            /// 9. seradit od nejmenší po největší, přeskočit první 3 a sečíst zbytek
            int result = numbers.OrderBy(n => n).Skip(3).Sum();
            Console.WriteLine($"vysledek: {result}");
            /// 10. seradit absolutní hodnoty od největší po nejmenší a vypsat první tři
            var result10 = numbers.OrderByDescending(x => Math.Abs(x)).Take(3);
            Console.WriteLine($"MaxAbs: {string.Join(", ", result10)}");
            */
            #endregion

            //Select - transformace
            #region Select
            /*
            int[] numbers = { -2079, -498, 2920, -1856, 332, -2549, -674, -120, -992, 2782, 320, -524, 135, 952, 1868, 2509, -230, -138, -904, -480 };

            //var result = numbers.Select(number => number + 10);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //úkol - vypsat absolutní hodnoty pro numbers
            var result = numbers.Select(n => Math.Abs(n));
            Console.WriteLine(string.Join(" ", result));
            */
            #endregion

            //samostatné úkoly

            var numbers = new[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var strings = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            /// 1. vypište čísla v poli numbers jako slova

            var sortedNumbers = numbers.Select(n => strings[n]);

            Console.WriteLine(string.Join(", ", sortedNumbers));




            Console.ReadLine();

        }
    }
}
