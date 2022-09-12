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
        }
    }
}
