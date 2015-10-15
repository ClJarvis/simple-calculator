using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Program
    {

        static void Main(string[] args)
        {
            ///user enters equation in 1+2 format
            int n = 1;
            while (n < 2) ///change condintion to while(exit equals false)
            {

                ///currently runs progran twice 1st input has = second just has [0] propmt
               int x = 0;
               for (int i = 0; i <= x; i++)
                    Console.WriteLine("[" + Counter.IncreaseCounter(i++) + "]>");


                string input = Console.ReadLine();
                var calculator = new ConsoleCalculator();
                var result = calculator.Calculate(input);

                Console.WriteLine("= " + result);
                Console.WriteLine("Press any key to exit.");
                Console.ReadLine();
            } //END OF While statement
        }
        //Add a COUNTER() 
        //add loop to run program again While Loop?
    }
}
