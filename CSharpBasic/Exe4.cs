using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    public class Exe4
    {
        public bool checkSquareNumbers()
        {
            Console.Write("Input number of list: ");
            int numberOfList = int.Parse(Console.ReadLine());

            int[] valueList = new int[numberOfList];

            for (int i = 0; i < numberOfList; i++)
            {
                Console.Write("Number " + (i + 1) + " : " + "");
                int inputtedValue = int.Parse(Console.ReadLine());
                valueList[i] = inputtedValue;
            }
                        
            Console.Write("List = [");
            for (int i = 0; i < valueList.Length; i++)
            {
                if (i != valueList.Length - 1)
                {
                    Console.Write(valueList[i] + ", ");
                }
                else
                {
                    Console.Write(valueList[i] + "]");
                }
            }
            Console.WriteLine();

            for (int i = 0; i < valueList.Length; i++)
            {
                int sqrt = (int)Math.Sqrt(valueList[i]);
                if (valueList[i] != sqrt * sqrt)
                {
                    return false;                    
                }
            }
            return true;
           
        }
    }
}
