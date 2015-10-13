﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Program
    {
        //public static bool Operations { get; private set; }

        static void Main(string[] args)
        {
            ///user enters equation in 1+2 format
         
            Console.WriteLine("[X]>");
         

            string input = Console.ReadLine();
            var calculator = new ConsoleCalculator();
            var result = calculator.Calculate(input);

            Console.WriteLine("= " + result );

          
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();

        }
        //Add a COUNTER() 
        public static void Exit()
        {

        }
    }
}
