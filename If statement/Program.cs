using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2,or 3: ");
            String userValue = Console.ReadLine();

            if (userValue == "1")
            {
                String message = "you won a car!";
                Console.WriteLine(message);
            }
            else if (userValue == "2")
            {
                String message = "you won a new boat";
                Console.WriteLine(message);
            }
            else if (userValue == "3")
            {
                String message = "you won a new cat";
                Console.WriteLine(message);
            }
            else
            {
                String message = "sorry we didn't understand";
                Console.WriteLine(message);
            }

            Console.ReadLine();
            
        }
    }
}
