using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizQuest
{
    class Program
    {
        public static void Main(string[] args)
        {
            Details();
        }
        
        static string name;
        public static void Details()
        {
            
            string address;
            int age;
            var storeDetails = "";


            Console.WriteLine("Welcome to the first ever online trivia night powered by Dee. To continue press enter");
            Console.ReadKey();

            Console.WriteLine("Before we begin please answer the questions below.");
        Name:
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();

            while (name == "")
            {
                Console.WriteLine("Please enter a valid name");
                goto Name;
            }

            storeDetails = name;
            goto Address;

        Address:
            Console.WriteLine("Please enter your email address");
            address = Console.ReadLine();

            while (address == "")
            {
                Console.WriteLine("Please enter a valid email address");
                goto Address;
            }

            storeDetails += "," + address;
            goto Age;

        Age:
            Console.WriteLine("Please enter your age");
            bool correctAge = int.TryParse(Console.ReadLine(), out age);

            while (!correctAge)
            {
                Console.WriteLine("Please enter a valid age");
                goto Age;
            }

            storeDetails += "," + age;

            Console.WriteLine("The quiz you are about to write has ten(10) questions and four(4) multiple choice answers.");
            Console.WriteLine("Please enter one answer and press enter to move to the next question");
            Console.WriteLine("");
            Console.WriteLine("Press enter to start");

            TestQuestions();

           
        }

        
        public static void TestQuestions()
        {
            int result = 0;
            var userAnswers = "";
            string answer = "";
            string[] questions = 
            {@"1.  How many valves does a trumpet have? 
 (a) 3   
 (b) 5    
 (c) 4   
 (d) 2",
@"2.  A bill that applies to the whole population and is intended to promote the general welfare is called?
(a) A private bill 
(b) A decree
(c) An Appropriation bill
(d) A public deal",
 @"3.  Where is the smallest bone in the body? 
(a) Ear     
(b) Toe		
(c) Nose		
(d) Fingers",
 @"4.  Who painted the Mona Lisa? 
(a) Leonardo Da Vinci	
(b) Vincent Van Gogh	
(c) Slvador Dali		
(d) Edouard Manet",
@"5.  Who said E=mc2? 
(a) Albert Einstein     
(b) Stephen Hawking     
(c) Isaac Newton		
(d) Thomas Edison",
@"6.  What is the capital of Kenya? 
(a) Nairobi		
(b) Cairo	
(c) Conakry     
(d) ape Town",

 @"7.  What type of elephant has got the biggest ears? 
(a) African	
(b)Indian	
(c)Asain		
(d) Straight tusked",

 @"8.  What is the second fastest land animal? 
(a) Pronghorn antelope 	
(b) Peregrine Falcon	
(c) Blue Wildebeest	
(d) Elk",
@"9.  The eiffel tower was originally invented for what city? 
(a) Barcelona	
(b) Singapore	
(c) Tokyo	
(d) Seoul",
@"10. The Jungle Book' what type of animal was Kaa? 
(a) Snake	
(b) Baboon	
(c) Cheetah	
(d)Lion"
            };

            string[] questionAnswers = { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a" };

            foreach(var n in questions)
            {
                Console.WriteLine(n);

                ChooseAnswer:
                    answer = Console.ReadLine();

                if(answer=="a" || answer=="b" || answer=="c" || answer=="d")
                {
                    foreach (var i in questionAnswers)
                    {
                        if (answer == i)
                        {
                            result += 1;
                        }
                        else
                        {
                            result += 0;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an answer from the options above");
                    goto ChooseAnswer;
                }

                userAnswers += "," + answer; 
                
            }

            Console.ReadKey();
            
            Console.WriteLine($"Dear {name} your answers were {userAnswers} and you scored {result}");
            
            WriteLine($"Would you like to take teh test again? Y[Yes] / N[No]");
            string reply = ReadLine().ToUpper();

            if (reply == "y")
            {
                Details();
            }
            else
            {
                ReadKey();
            }


        }
    }
}
