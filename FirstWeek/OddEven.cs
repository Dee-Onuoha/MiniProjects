using System;
using static System.Console;

class OddEven {

    static void OddEv(String [] args)
    {
        int a;

        Write($"Input number you want to check > ");
        a = int.Parse(ReadLine());

        int Test = Even(a);

        WriteLine(Test == 0 ? "{0} is an even number" : "{0} is an odd number", a,a);
    }

    static int Even(int a)
    {
        return a % 2;
    }
}