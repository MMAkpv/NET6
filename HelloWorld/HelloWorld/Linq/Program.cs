using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, -30, 4, 20, 256, -45, 99 };

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

            //dalsi fce

            var resultSum = numbers.Sum(); //suma cisel, vraci int, stejne by slo pouzit napr. Max, Min, Average

            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
