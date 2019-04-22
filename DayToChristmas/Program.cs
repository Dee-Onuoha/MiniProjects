using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayToChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime chritmasDay = new DateTime(2019, 12, 25);
            DateTime today = DateTime.Now;

            var numberOfDays = chritmasDay-today;

            var numberOfMonth = chritmasDay.Month - today.Month;

            string dayToChristmas = $"We have {numberOfMonth} months or {numberOfDays.ToString(@"dd")} days and {numberOfDays.ToString(@"hh")}";
            Console.WriteLine(dayToChristmas);

Console.ReadKey();
        }
    }
}
