using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektoveProgramovani.Model
{
    class Car
    {
        public string Color { get; set; }
        public string PlateNumber { get; set; }
        public double TotalKm { get; set; }

        public void AddTripKm(double tripLenght)
        {
            TotalKm += tripLenght;
        }

        public void ResetTotalKm()
        {
            TotalKm = 0;
        }
    }
}
