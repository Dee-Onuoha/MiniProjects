using System;
using static System.Console;

namespace NumberToWord
{
    class Program
    {
            static void Main(string[] args)
        {
            NumToWord();
        }

        static void NumToWord()
        {


            NumberConverter:
            Write("Please enter the number you would like to convert > ");
            long number = long.Parse(ReadLine());

            int len = (number.ToString()).Length;
            string wordConvert;

            if (len >= 1 && len <= 2)
            {
                wordConvert = UnitTenConverter(number);
                WriteLine($"The word equivalent of {number} is {wordConvert}");
            }
            else if(len == 3)
            {
                wordConvert = HundredConverter(number);
                WriteLine($"The word equivalent of {number} is {wordConvert}");
            }
            else if (len == 4 || len == 5)
            {
                wordConvert = ThousandConverter(number);
                WriteLine($"The word equivalent of {number} is {wordConvert}");
            }            
            else if (len == 6)
            {
                wordConvert = HundredThousandConverter(number);
                WriteLine($"The word equivalent of {number} is {wordConvert}");
            }
            else if (len == 7 || len == 8)
            {
                wordConvert = MillionConverter(number);
                WriteLine($"The word equivalent of {number} is {wordConvert}");
            }
            else if (len == 9)
            {
                wordConvert = HundredMillionConverter(number);
                WriteLine($"The word equivalent of {number} is {wordConvert}");
            }
            else if (len == 10 || len == 11)
            {
                wordConvert = BillionConverter(number);
                WriteLine($"The word equivalent of {number} is {wordConvert}");
            }
            else if (len == 12)
            {
                wordConvert = HundredBillionConverter(number);
                WriteLine($"The word equivalent of {number} is {wordConvert}");
            }

            WriteLine($"Would you like to convert another number? Yes[Y] / NO[N]");

            string userReply = ReadLine().ToUpper();
            if (userReply == "Y")
            {
                goto NumberConverter;
            }

            ReadKey();
        }

        static string words = "";

        static string[] units = {"","one","two","three","four","five","six","seven","eight","nine","ten",
        "eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"};

        static string[] tens = { "","", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        private static string[] hundreds =
        {
            "", "one hundred", "two hundred", "three hundred", "four hundred", "five hundred",
            "six hundred", "seven hundred", "eight hundred", "nine hundred"
        };
        
        static string UnitTenConverter(long number)
        {
            long ten = number / 10;
            long unit = number % 10; 

            if (number >= 0 && number <= 19)
            {
                words = units[number];
            }

            else if(number >= 20 && number <= 99)
            {
                words = tens[ten] + " " + units[unit];
            }

            return words;
        }

        static string HundredConverter(long number)
        {
           long hundredthDigit = number / 100;
           long hundredthMod = number % 100;

            if(hundredthMod == 0)
            {
                words = hundreds[hundredthDigit];
            }
            else if(hundredthMod != 0)
            {
                words = hundreds[hundredthDigit] + " and " + UnitTenConverter(hundredthMod);
            }

            return words;
        }

        static string ThousandConverter(long number)
        {
            long thousandth = number / 1000;
            long thousandthMod = number % 1000;
            
            long tenThousandth = number / 1000;
            long tenThousandthMod = number % 1000;

            long hundredThousandth = number / 1000;
            long hundredThousandthMod = number % 1000;
                

            if (thousandthMod == 0)
            {
                words = UnitTenConverter(thousandth) + " thousand";
            }
            else if (thousandthMod != 0)
            {
                words = UnitTenConverter(thousandth) + " thousand " + HundredConverter(thousandthMod);
            }
            else if (tenThousandthMod == 0)
            {
                words = UnitTenConverter(tenThousandth) + " thousand";
            }
            else if (tenThousandthMod != 0)
            {
                 words = UnitTenConverter(tenThousandth) + " thousand " + HundredConverter(tenThousandthMod);
            }  
            /*else if (hundredThousandthMod == 0)
            {
                words = HundredConverter(hundredThousandth) + " thousand";
            }
            else if (hundredThousandthMod != 0)
            {
                words = HundredConverter(hundredThousandth) + " thousand " + HundredConverter(hundredThousandthMod);
            }*/            
            
            return words;

        }
        
        static string HundredThousandConverter(long number)
        {
            long hundredThousandth = number / 1000;
            long hundredThousandthMod = number % 1000;
            
            if (hundredThousandthMod == 0)
            {
                words = HundredConverter(hundredThousandth) + " thousand";
            }
            else if (hundredThousandthMod != 0)
            {
                words = HundredConverter(hundredThousandth) + " thousand " + HundredConverter(hundredThousandthMod);
            }
    
            return words;
        }

        static string MillionConverter(long number)
        {
            long millionth = number / 1000000;
            long millionthMod = number % 1000000;

            long tenMillionth = number / 1000000;
            long tenMillionthMod = number % 1000000;

            long hundredMillionth = number / 1000000;
            long hundredMillionthMod = number % 1000000;

            if (millionthMod == 0)
            {
                words = UnitTenConverter(millionth) + " million";
            }
            else if (millionthMod != 0)
            {
                words = UnitTenConverter(millionth) + " million " + HundredThousandConverter(millionthMod);
            }
            else if (tenMillionthMod == 0)
            {
                words = UnitTenConverter(tenMillionth) + " million";
            }
            else if (tenMillionthMod != 0)
            {
                words = UnitTenConverter(tenMillionth) + " million " + HundredThousandConverter(tenMillionthMod);
            }
            /*else if (hundredMillionthMod == 0)
            {
                words = HundredConverter(hundredMillionth) + " million ";
            }
            else if (hundredMillionthMod != 0)
            {
                words = HundredConverter(hundredMillionth) + " million " + HundredThousandConverter(hundredMillionthMod);
            }*/

            return words;
        }
        
        static string HundredMillionConverter(long number)
        {
            long hundredMillionth = number / 1000000;
            long hundredMillionthMod = number % 1000000;

            
            if (hundredMillionthMod == 0)
            {
                words = HundredConverter(hundredMillionth) + " million";

            }
            else if (hundredMillionthMod != 0)
            {
                words = HundredConverter(hundredMillionth) + " million " + HundredThousandConverter(hundredMillionthMod);
            }

            return words;
        }
        
        static string BillionConverter(long number)
        {
            long billionth = number / 1000000000;
            long billionthMod = number % 1000000000;

            long tenBillionth = number / 1000000000;
            long tenBillionthMod = number % 1000000000;

            long hundredBillionth = number / 1000000000;
            long hundredBillionthMod = number % 1000000000;

            if (billionthMod == 0)
            {
                words = UnitTenConverter(billionth) + " billion";
            }
            else if (billionthMod != 0)
            {
                words = UnitTenConverter(billionth) + " billion " + HundredMillionConverter(billionthMod);
            }
            else if (tenBillionthMod == 0)
            {
                words = UnitTenConverter(tenBillionth) + " billion";
            }
            else if (tenBillionthMod != 0)
            {
                words = UnitTenConverter(tenBillionth) + " billion " + HundredMillionConverter(tenBillionthMod);
            }
            /*else if (hundredMillionthMod == 0)
            {
                words = HundredConverter(hundredMillionth) + " million ";
            }
            else if (hundredMillionthMod != 0)
            {
                words = HundredConverter(hundredMillionth) + " million " + HundredThousandConverter(hundredMillionthMod);
            }*/

            return words;
        }
        
        static string HundredBillionConverter(long number)
        {
            long hundredBillionth = number / 1000000000;
            long hundredBillionthMod = number % 1000000000;

            
            if (hundredBillionthMod == 0)
            {
                words = HundredConverter(hundredBillionth) + " billion";

            }
            else if (hundredBillionthMod != 0)
            {
                words = HundredConverter(hundredBillionth) + " billion " + HundredMillionConverter(hundredBillionthMod);
            }

            return words;
        }
        
        
    }
}
