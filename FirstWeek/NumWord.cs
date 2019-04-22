using System;
using static System.Console;

class NumToWord
{
    static void Main(string[] args)
    {
        
        int Number;

        Write("Please enter the number you would like to convert > ");
        number = int.Parse(ReadLine());

        string wordConvert = Convert(number);

        WriteLine($"The word equivalent of {number} is {wordConvert}");
        
    }

    static  string Convert(int Number)
    {
        string Words = "";

        var Unit = new[] {"zero","one","two","three","four","five","six","seven","eight","nine","ten",
        "eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen"};

        var Ten = new[] {"zero","twenty","thirty","forty","fifty","sixty","seventy","eighty","ninty"};

        var Hundred = new[] {"hundred", "two hundred", "three" };



       if (Number >=0 && Number <=19)
       {
           Words = Words + Unit[Number];
       }

       /*else
       {
           Words = Words + Ten[Number];

           if ((Number % 10) > 0)
                Words = Words + "-" + Ten[Number % 10];
       }*/

       return Words;
        
    }

    
}