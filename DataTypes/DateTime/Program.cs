using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* DateTime Today = DateTime.Today;
             Write(Today);

             DateTime NowUtc = DateTime.UtcNow;
             DateTime Now = DateTime.UtcNow;
             WriteLine($"Now : {Now}, UTC Now: {NowUtc}");

             DateTime dateOfBirth = new DateTime(1993, 06, 05);
             double Age = DateTime.Today.Subtract(dateOfBirth).TotalDay;
             WriteLine(Age / 365);

             int Duration = 7;
             DateTime SubDate = DateTime.Now, eXpiresOn = SubDate.AddDays(Duration);
             string msg = $"Welcome to MTN Data Plan for {Duration}";
             sendSmsSub(msg); */

            var states = new List<string>
            {
                "abia",
                "umahia",
                "adamawa",
                "yola",
                "imo",
                "owerri",
                "jigawa",
                "kaduna",

            };

            var someStates = states
                                   .Skip(3)
                                    .Where(x => x.StartWith("E"))
                                    .Take(5);
            ReadKey();
        }

        static void EscapeCharacter()
        {
            string Vertum = @"";
            string fileName = "C\\:myDirectoryName\file.pdf";
            string firstName = "John", lastNme = "Doe", address = "Computer Village Ikeja",
                quoteOfTheDay = "Nothing";

            WriteLine($"{firstName}\t{lastNme}\n{address}\n\"{quoteOfTheDay}");
        }
    }
}
