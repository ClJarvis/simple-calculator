﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleCalculator
{
    public class ConsoleCalculator
    {
        private int FirstInt { get; set; }
        private int SecondInt { get; set; }
        private Char[] delimiterChars = { '+', '-', '*', '/', '%' };
        private int LeftInt;
        private int RightInt;

        public string[] GetNumbers(string input)
        {
           
            return input.Split(delimiterChars);
 
        }

        public Char GetOperator(string input)
        {
            foreach (char character in delimiterChars)
            {
                if (input.Contains(character)){
                    return character;
                }

            }
            throw new InvalidOperationException();
        }
        public int Calculate(string input)
        {

            //convert string to Int

           // var result = Convert.ToInt32(Console.ReadLine());
            var result = Convert.ToInt32(input);

            char Operator = default(char);
            switch (Operator)
            {
                case '+':
                    return AddNum(); //FirstInt + SecondInt;
                case '-':
                    return FirstInt - SecondInt;
                //break;
                case '*':
                    return FirstInt * SecondInt;
                // break;
                case '/':
                    return FirstInt / SecondInt;
                // break;
                case '%':
                    return FirstInt % SecondInt;
                // break;
                default:
                    throw new ArgumentException("incorrect format");
                    // break;
            }


            //use switch to call add and other methods, rework methods
        }

        private int AddNum()
        {
            throw new NotImplementedException();
        }
    }

}
 
           ///bool parsed = Int32.TryParse(input, out result);
           /// if (!parsed)
            ///Console.WriteLine("Int32.TryParse could not parse '{0}' to an int.\n", input);
