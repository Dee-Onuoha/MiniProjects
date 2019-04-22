using System;
using static System.Console;

class RevString
{
    public static void RevStr(string[] args)
    {
        int StringLength = 0;
        string Str = "" , Reverse = "";

        Write("Input String to reverse > ");
        Str = ReadLine();

        StringLength = Str.Length;

        WriteLine("The length of {0} is {1}", Str, StringLength);

        while(StringLength > 0)
        {
            Reverse = Reverse + Str[StringLength-1];
            StringLength--;
        }

        WriteLine("The reverse of {0} is {1}", Str, Reverse);
    }
}