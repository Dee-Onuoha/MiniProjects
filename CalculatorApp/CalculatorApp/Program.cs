using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator;

            cal.LCD.Answer = "33000";   //nOT GOING TO RUN

            cal.PressNumber(CalculatorNumbers.Num4);
            cal.PressNumber(CalculatorNumbers.Num6);

            Console.WriteLine(cal.LCD.Label);
            Console.ReadLine();
        }
    }
}
