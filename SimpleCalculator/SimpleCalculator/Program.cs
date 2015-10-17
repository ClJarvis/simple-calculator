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
            int n = 0;
            int x = 0;
            bool run = true;
            while (run == true ) ///change condintion to while(continue equals false)
              
            {
                ///currently runs progran twice 1st input has = second just has [0] propmt  
                ///  output exmaple at bottom of page.    
                ///       
                //counter increases [n] 

                Console.WriteLine("[" + x + "]>");
                
                string input = Console.ReadLine();
                var calculator = new ConsoleCalculator();
                var result = calculator.Calculate(input);
                while (input == "quit" )
                {
                    run = false;
                }      
                Console.WriteLine("   = " + result);
                x++;
                //Console.WriteLine("Press any key to exit."); 
                Console.ReadLine(); //ReadKey();
                
            } //END OF While statement
        }
        //Add a COUNTER() 
        //add loop to run program again While Loop?
    }
}

                /*
                    [0]>
                    1+1
                    = 2
                    Press any key to exit.
                    1+2  //no  "= answer" or "press to exit" on every other input
                    [1]>
                    1+3
                    = 4
                    Press any key to exit.
                    1+4 //no = answer
                    [2]>
                    1+5
                    = 6
                    Press any key to exit.
                    1=6 //no = answer
                    [3]>
                    1+7
                    = 8
                    Press any key to exit
                 */
