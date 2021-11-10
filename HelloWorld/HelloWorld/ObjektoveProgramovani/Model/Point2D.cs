using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektoveProgramovani.Model
{
    class Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// metoda vraci obsah od [0,0] k zadanemu bodu
        /// </summary>
        /// <returns></returns>
        public int Area()
        {
            return X * Y;
        }

        /// <summary>
        /// metoda k zadanému bodu přičte druhý bod a výsledek vrátí jako nový bod
        /// </summary>
        /// <param name="point"></param>
        /// <returns>novy bod jako soucet 2 bodu</returns>
        public Point2D Add2Points(Point2D point) //vzniká nový bod
        {
            Point2D soucetBodu = new Point2D(X + point.X, Y + point.Y);
            return soucetBodu;
        }


        /// <summary>
        /// metoda modifikuje stavajici bod
        /// </summary>
        /// <param name="point"></param>
        public void AddPoint(Point2D point) //nevzniká nový bod
        {
            X += point.X;
            Y += point.Y;
        }

        /// <summary>
        /// prepsana metoda ToString(), aby print tiskl vystup podle naseho pozadavku
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Souřadnice bodu jsou [{X},{Y}], plocha od [0,0] k zadanému bodu je {Area()} jednotek^2";
        }
    }
}
