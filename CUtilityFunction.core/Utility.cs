using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CUtilityFunction.core
{
    public class UtilityFunctions
    {
        public class BinaryConvertionFunction
        {
            public static string ToDec(string numberToConvert, int currentBase)
            {
                string number = numberToConvert.ToUpper();
                int temp = 0;
                long decimalValue = 0;
                int power = (number.Length) - 1;
                int len = number.Length;
                string integerResult = "";
                string hex = "0123456789abcdef".ToUpper();

                for (int i = 0; i < len; i++)
                {
                    if (hex.IndexOf(number[i]) > currentBase)
                    {
                        WriteLine("Invalid base conversion");
                        return integerResult = "-1";
                    }
                    else
                    {
                        temp = hex.IndexOf(number[i]);
                        decimalValue += (long)(temp * Math.Pow(currentBase, power));
                        power--;
                    }                   

                }

                return integerResult = decimalValue.ToString();

            }

            public static string AnyBase(string numberToConvert, int currentBase, int newBase)
            {
                string[] hex = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f".ToUpper() };
                string answer = "";
                string newQuotient = "";
                long temp = long.Parse(ToDec(numberToConvert, currentBase));


                while (temp > 0)
                {
                    long quotient = temp % newBase;
                    newQuotient = hex[quotient].ToUpper();
                    temp = temp / newBase;
                    answer = newQuotient + answer;

                }

                return answer;
            }

        }

        

        public class NumberToWordFunction
        {

            public static string NumToWord(long number)
            {                

                int len = (number.ToString()).Length;
                string wordConvert = "";

                if (len >= 1 && len <= 2)
                {
                    return wordConvert = UnitTenConverter(number);

                }
                else if (len == 3)
                {
                    return wordConvert = HundredConverter(number);
                }
                else if (len == 4 || len == 5)
                {
                    return wordConvert = ThousandConverter(number);
                }
                else if (len == 6)
                {
                    return wordConvert = HundredThousandConverter(number);
                }
                else if (len == 7 || len == 8)
                {
                    return wordConvert = MillionConverter(number);
                }
                else if (len == 9)
                {
                    return wordConvert = HundredMillionConverter(number);
                }
                else if (len == 10 || len == 11)
                {
                    return wordConvert = BillionConverter(number);
                }
                else if (len == 12)
                {
                    return wordConvert = HundredBillionConverter(number);
                }

                return wordConvert;

            }

            static string words = "";

            static string[] units = {"","one","two","three","four","five","six","seven","eight","nine","ten",
        "eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"};

            static string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            static string[] hundreds =
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

                else if (number >= 20 && number <= 99)
                {
                    words = tens[ten] + " " + units[unit];
                }

                return words;
            }

            static string HundredConverter(long number)
            {
                long hundredthDigit = number / 100;
                long hundredthMod = number % 100;


                if (hundredthMod > 0 && hundredthMod <= 999)
                {
                    words = hundreds[hundredthDigit] + " and " + UnitTenConverter(hundredthMod);
                }
                else if (hundredthMod == 0)
                {
                    words = hundreds[hundredthDigit];
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
                else if (hundredThousandthMod > 0 && hundredThousandthMod <= 999)
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

                if (millionthMod == 0)
                {
                    words = UnitTenConverter(millionth) + " million";

                }
                else if (millionthMod > 0 && millionthMod <= 999)
                {
                    words = UnitTenConverter(millionth) + " million " + HundredConverter(millionthMod);
                }
                else if (millionthMod >= 1000 && millionthMod <= 999999)
                {
                    words = UnitTenConverter(millionth) + " million " + HundredThousandConverter(millionthMod);
                }
                else if (tenMillionthMod == 0)
                {
                    words = UnitTenConverter(tenMillionth) + " million";

                }
                else if (tenMillionthMod > 0 && tenMillionthMod <= 999)
                {
                    words = UnitTenConverter(tenMillionth) + " million " + HundredConverter(tenMillionthMod);
                }
                else if (tenMillionthMod >= 1000 && tenMillionthMod <= 999999)
                {
                    words = UnitTenConverter(tenMillionth) + " million " + HundredThousandConverter(tenMillionthMod);
                }

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
                else if (hundredMillionthMod > 0 && hundredMillionthMod <= 999)
                {
                    words = HundredConverter(hundredMillionth) + " million " + HundredConverter(hundredMillionthMod);
                }
                else if (hundredMillionthMod >= 1000 && hundredMillionthMod <= 999999)
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

                if (billionthMod == 0)
                {
                    words = UnitTenConverter(billionth) + " billion";

                }
                else if (billionthMod > 0 && billionthMod <= 999)
                {
                    words = UnitTenConverter(billionth) + " billion " + HundredConverter(billionthMod);
                }
                else if (billionthMod >= 1000 && billionthMod <= 999999)
                {
                    words = UnitTenConverter(billionth) + " billion " + HundredThousandConverter(billionthMod);
                }
                else if (billionthMod >= 1000000 && billionthMod <= 999999999)
                {
                    words = UnitTenConverter(billionth) + " billion " + HundredMillionConverter(billionthMod);
                }
                else if (tenBillionthMod == 0)
                {
                    words = UnitTenConverter(tenBillionth) + " billion";

                }
                else if (tenBillionthMod > 0 && tenBillionthMod <= 999)
                {
                    words = UnitTenConverter(tenBillionth) + " billion " + HundredConverter(tenBillionthMod);
                }
                else if (tenBillionthMod >= 1000 && tenBillionthMod <= 999999)
                {
                    words = UnitTenConverter(tenBillionth) + " billion " + HundredThousandConverter(tenBillionthMod);
                }
                else if (billionthMod >= 1000000 && billionthMod <= 999999999)
                {
                    words = UnitTenConverter(billionth) + " billion " + HundredMillionConverter(billionthMod);
                }


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
                else if (hundredBillionthMod > 0 && hundredBillionthMod <= 999)
                {
                    words = HundredConverter(hundredBillionth) + " billion " + HundredConverter(hundredBillionthMod);
                }
                else if (hundredBillionthMod >= 1000 && hundredBillionthMod <= 999999)
                {
                    words = HundredConverter(hundredBillionth) + " billion " + HundredThousandConverter(hundredBillionthMod);
                }
                else if (hundredBillionthMod >= 1000000 && hundredBillionthMod <= 999999999)
                {
                    words = HundredConverter(hundredBillionth) + " billion " + HundredMillionConverter(hundredBillionthMod);
                }


                return words;
            }

        }



}
    }

