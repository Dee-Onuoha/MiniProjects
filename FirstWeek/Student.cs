using System;
using static System.Console;

class Info
{
    static void StuInfo(string[] args)
    {
        string StuName;
        int Score;

        Write("Please input the student name > ");
        StuName = ReadLine();

        Write("Please input student score > ");
        Score =int.Parse(ReadLine());

        WriteLine(Score >= 80 ? "{0}'s grade is A" : Score >=65 && Score <=79 ? "{1}'s grade is AB)" :
         Score >=55 && Score <=64 ? "{2}'s grade is B" : Score >=45 && Score <=54 ? "{3}'s grade is C" :
         Score >=35 && Score <=44 ? "{4}'s grade is CD" : Score >=25 && Score <=34 ? "{5}'s grade is D" :
         Score >=15 && Score <=24 ? "{6}'s grade is E" : Score >=0 && Score <=14 ? "{7}'s grade is F" : 
         "Input Score for {StuNam8}", 
         StuName, StuName, StuName, StuName, StuName, StuName, StuName, StuName, StuName);
    }   
}