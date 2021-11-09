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

        public Car() { }

        public Car(string color, string plateNumber, double totalKm)
        {
            Color = color;
            PlateNumber = plateNumber;
            TotalKm = totalKm;
        }

        public override string ToString()
        {
            return $"Auto barvy {Color}, značky {PlateNumber} s {TotalKm} kilometry.";
        }

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
