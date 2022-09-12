using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Repeat 20 times
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"1 times {i + 1} is {i + 1}");
            }

            //Repeat until the user says "stop"
            bool saidStop = false;

            while(saidStop == false)
            {
                Console.WriteLine("Tell me to stop");
                saidStop = Console.ReadLine().ToLower() == "stop";


            }
            //repeats from 1 to 50
            for (int i = 1; i <= 50; i++)
            {
                //says if a number is odd or even
                string oddOrEven = "odd";
                string multipleOfThree = "not a multiple of three";

                if (i % 2 == 0)
                {
                    oddOrEven = "even";
                }

                if (i % 3 == 0)
                {
                    multipleOfThree = "a multiple of three";
                }


                Console.WriteLine($"{i} is {oddOrEven} and { multipleOfThree}");
            }
            
            // say if a number is divisible by three
           
        }
    }
}
