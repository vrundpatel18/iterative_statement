// Vrund Patel
// 1/29/23
// iterative statement assignment
using System.ComponentModel.Design.Serialization;

namespace iterative_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int input = 0;
            string series = "";
            
            while(true)
            {
                Console.WriteLine("Enter an integer number between 1 and 100: ");
                input = int.Parse(Console.ReadLine());

                if (input >= 1 && input <=100)
                {
                    break;
                }
            }

             while(true)
             {
                Console.WriteLine("Specify the series type as even or odd: ");
                series = Console.ReadLine();

                if (series == "even" || series == "odd")
                {
                    break;
                }
             }

                if (series == "odd")
                {
                    Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are: ");
                    for (int i = 1; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }

                if (series == "even")
                {
                    Console.WriteLine("You have selected " + series + " series. The numbers between 0 and " + input + " are: ");
                    for (int i = 0; i <= input; i = i + 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            
            

        }
    }
}