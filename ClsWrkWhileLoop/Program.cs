using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // While loop
            // Step 1: declare Initialize variable
            int i = 0;


            //Step 2: Define while Loop and check the condition
            while (i < 5)
            {
                Console.WriteLine(" Outer loop - The value is:" + i);
                int j = 0;
                while (j < 5)
                {
                    Console.WriteLine($" Inner loop - The value of J :{j}");
                    j++;
                }
               // step 3 : set the increment Counter
                i++;
            }
            int k = 0;
            do
            {
                Console.WriteLine($"The value of {k}");
                int l = 0;
                do
                {
                    Console.WriteLine($"The value of {k}");
                    k++;
                } while (k < 5);
                i++;
            } while (i < 5);
            Console.WriteLine(" ................");
            Console.ReadKey();
        }
    }
}
