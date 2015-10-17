using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleCalculator
{
    public class ConsoleCalculator
    {
        private Char[] delimiterChars = { '+', '-', '*', '/', '%' };
 
        public string[] GetNumbers(string input)
        {
           
            return input.Split(delimiterChars);
 
        }

        public char GetOperator(string input)
        {
            foreach (char character in delimiterChars)
            {
                if (input.Contains(character)){
                    return character;

                }

            }
             throw new InvalidOperationException();
         
          // throw new ArgumentException("Invalid Input you did not include a mathmatic symbol");
        }
        public int Calculate(string input)
        {
            //collecting and adding operans(the ints) and the Operators(char math operators to buils equation
            var operans = GetNumbers(input);
            var op = GetOperator(input);
            //use switch to call add and other corresponding methods 
            switch (op)
            {
                case '+':
                    return addition.AddNum(operans); 
                case '-':
                    return Subtraction.SubtractNum(operans); 
                case '*':
                    return Multiply.MultiplyNum(operans);
                case '/':
                    return Divison.DivideNum(operans);
                case '%':
                    return Modulus.ModulusNum(operans);
                default:
                    throw new ArgumentException("incorrect format");
                    
            }
           
        }


    }

}


//   int i = 0;

// return i;
//Console.WriteLine("[" + i++ + "]>");

///bool parsed = Int32.TryParse(input, out result);
/// if (!parsed)
///Console.WriteLine("Int32.TryParse could not parse '{0}' to an int.\n", input);
