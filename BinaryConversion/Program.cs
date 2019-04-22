using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            NumToWordConverter();
          
        }

        static void NumToWordConverter()
        {
            BaseConvert:
            Write("Enter Number you like to convert > ");
            string numberToConvert = ReadLine();

            Write("From base? > ");
            int currentBase = int.Parse(ReadLine());

            Write("To base? > ");
            int newBase = int.Parse(ReadLine());

            string result = AnyBase(numberToConvert, currentBase, newBase);

            WriteLine($"The conversion of {numberToConvert} from base {currentBase} to base {newBase} is > {result}");

            WriteLine("Do you want to perform another conversion? (Y = Yes / N = No)");
            string reply = ReadLine().ToUpper();

            if (reply == "Y")
            {
                goto BaseConvert;
            }
            else
            {
                if (reply == "N")
                {
                    ReadKey();
                }
            }  
        }
        static string ToDec(string numberToConvert, int currentBase)
        {
            string number = numberToConvert.ToUpper();
            int temp = 0;
            long decimalValue = 0;
            int power = (number.Length) - 1;
            int len = number.Length;
            string integerResult = "";
            string hex = "0123456789abcdef".ToUpper();

            for(int i = 0; i < len; i++)
            {
                if(hex.IndexOf(number[i]) >= currentBase)
                {
                    WriteLine("Invalid base conversion");
                    return integerResult = "-1";
                }
                
                
                temp = hex.IndexOf(number[i]);
                decimalValue += (long)(temp * Math.Pow(currentBase, power));
                power--;
                        
            }
            
            return integerResult = decimalValue.ToString();

        }
        
        static string AnyBase(string numberToConvert, int currentBase, int newBase)
        {    
            string[] hex = {"0", "1", "2", "3","4","5","6","7","8","9","a","b","c","d","e","f".ToUpper()};            
            string answer = "";
            string newQuotient = "";
            long temp = long.Parse(ToDec(numberToConvert, currentBase));

           
               while(temp > 0)
                {
                   long quotient = temp % newBase;
                   newQuotient = hex[quotient].ToUpper();
                   temp = temp / newBase; 
                   answer = newQuotient + answer;                    
                    
                }                            

            return answer; 
        }
        
    }
}
