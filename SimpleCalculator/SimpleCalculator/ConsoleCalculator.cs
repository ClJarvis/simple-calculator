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
        public string Calculate(string input)
        {
            if (input == "lastq")
            {
                Console.WriteLine(Stack.lastQuestion);
                return Stack.lastQuestion;
               
            }
            else if (input == "last")
            {
                Console.WriteLine(Stack.last);
                return Stack.last;
            }
            else if (input == "exit")
            {
                Console.WriteLine(Stack.lastQuestion);
                return Stack.exit;
            }
            {
                //collecting and adding operans(the ints) and the Operators(char math operators to buils equation
                var operans = GetNumbers(input);
                var op = GetOperator(input);
                var result = 0;
                //use switch to call add and other corresponding methods 
                switch (op)
                {
                    case '+':
                        result  = addition.AddNum(operans);
                        break;
                    case '-':
                        result = Subtraction.SubtractNum(operans);
                        break;
                    case '*':
                        result = Multiply.MultiplyNum(operans);
                        break;
                    case '/':
                        result = Divison.DivideNum(operans);
                        break;
                    case '%':
                        result = Modulus.ModulusNum(operans);
                        break;
                    default:
                        throw new ArgumentException("incorrect format");

                }
                return result.ToString();

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
