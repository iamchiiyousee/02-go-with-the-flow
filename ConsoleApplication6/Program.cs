using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Burger Program!");
            Console.WriteLine("^_^");
            Console.WriteLine("Would you like a burger today?");
            String answer = (Console.ReadLine());

            if (answer.ToLower() == "yes")
            {
                Console.WriteLine("Great, one burger. Would you like fries with that?");
                answer = (Console.ReadLine()); 

            if (answer.ToLower() == "yes")
            {
                Console.WriteLine("Fantastic! Okay, one more thing, would you like a drink with your meal?");
                answer = (Console.ReadLine());
                    

            }

            }



            else
            {
                Console.WriteLine("That's not what I asked.");
                Console.ReadLine();
                Console.WriteLine("Would you like a burger today?");
                Console.ReadLine();
            }
            if (answer =="No")
            {
                Console.WriteLine("Okay, would you like anything else?");
                Console.ReadLine();
            }
        }
    }
}
