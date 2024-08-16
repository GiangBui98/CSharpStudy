using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    public class Exe7
    {
        public void RefineString()
        {
            Console.WriteLine("Input the string to test my function: ");
            string input = Console.ReadLine();
           /* Console.WriteLine(input);*/

            char[] result = new char[input.Length];
            int index = 0;

            result[index++] = input[0];


            for(int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    result[index++] = input[i];

                }
            }
            
            Console.WriteLine("Initial string: " + input);

            Console.Write("Refined string: ");
            foreach (char c in result)
            {
                Console.Write(c);
            } 
        }
    }
}
