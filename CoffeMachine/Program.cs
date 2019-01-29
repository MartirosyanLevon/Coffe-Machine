using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coffe cap siz: 1- Small 2- Middle 3- Big");
            Console.WriteLine("Please make your choice");
            string cofeSize = Console.ReadLine();
            int cost = 0;

            switch (cofeSize)
            {
                case "1":
                    cost += 25;
                    break;
                case "2":
                    cost += 25;
                    goto case "1";
                case "3":
                    cost += 50;
                    goto case "1";
                default:
                    Console.WriteLine("Wrong choice.Please choice 1,2 or 3");
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine("Pay {0} cent \nThank you", cost);
            }
            else
            {
                Console.WriteLine("Please repeat selection!!!");
            }

            Console.ReadKey();
        }
    }
}
