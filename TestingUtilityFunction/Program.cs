using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CUtilityFunction.core.UtilityFunctions;
using static System.Console;


namespace TestingUtilityFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            NumToWord();

            BaseToBaseConverter();

            ReadLine();
        }

        static void BaseToBaseConverter()
        {
            
                string result = BinaryConvertionFunction.AnyBase("abc", 2, 10);
            WriteLine(result);
               
        }

        static void NumToWord()
        {


            string result = NumberToWordFunction.NumToWord(9_000_000_765);
            WriteLine(result);
            WriteLine(NumberToWordFunction.NumToWord(90003));

        }
    }
}
