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
            String Burger = (Console.ReadLine());

            if (Burger == "yes")
            {
                Console.WriteLine("Great, one burger. Would you like fries with that?");
                String Fries = (Console.ReadLine()); 

            if (Fries == "Yes")
            {
                Console.WriteLine("Fantastic! Okay, one more thing, would you like a drink with your meal?");
                String Drink = (Console.ReadLine());

            }

            }



            else
            {
                Console.WriteLine("That's not what I asked.");
                Console.ReadLine();
                Console.WriteLine("Would you like a burger today?");
                Console.ReadLine();
            }
            if (Burger =="No")
            {
                Console.WriteLine("Okay, would you like anything else?");
                Console.ReadLine();
            }
        }
    }
}
