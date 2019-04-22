using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public enum CalculatorNumbers
    {
        Num0 = 0,
        Num1 = 1,
        Num2,
        Num3, NUm4, Num5, Num6, Num7, Num8, Num9
    };

    public enum CalculatorOperator
    {
        Plus,
        Minus,
        Mul,
        Eql,
        Div,
        Decimal,
        PlusMinus,
        BackSpace,
        CE,
        C,
        Sqr,
        Sqrt
    };
    class Calculator
    {
        public void PressNumber(CalculatorNumbers num)
        {
            lcd.Label += ((int)num).ToString();
        }

        public void PressOperator(CalculatorOperator op)
        {
            if(op == CalculatorOperator.Eql)
            {
                lcd.Result = lcd.Label; v
            }
        }

        CalDisplay lcd = new CalDisplay();
        public CalDisplay LCD
        {
            get
            {
                return lcd; 
            }
        }

        public string Result { get; internal set; } = "";
            
        public string Label { get; set; }
    }

}
