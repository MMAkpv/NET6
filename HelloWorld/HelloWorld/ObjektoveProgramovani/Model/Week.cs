using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektoveProgramovani.Model
{
    class Week
    {
        public static string DayOfWeekWithSwitch(int number)
        {
            switch (number)
            {
                case 1:
                    return ("Pondělí");
                case 2:
                    return ("Úterý");
                case 3:
                    return ("Středa");
                case 4:
                    return ("Čtvrtek");
                case 5:
                    return ("Pátek");
                case 6:
                    return ("Sobota");
                case 7:
                    return ("Neděle");
                default:
                    return ("Špatný údaj");
            }
        }

        public static string DayOfWeekWithArray(int number)
        {
            number -= 1;
            string[] days = new string[] { "pondělí", "úterý", "středa", "čtvrtek", "pátek", "sobota", "neděle" };
            if (number >= 1 & number <= 7)
            {
                return (days[number]);
            }
            else
            {
                return ("špatná hodnota");
            }
        }
    }
}
