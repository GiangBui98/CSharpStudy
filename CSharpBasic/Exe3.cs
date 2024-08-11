using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    public class Exe3
    {
        public int findTheSmallestNumber()
        {
            Console.Write("Input number of list: ");
            int numberOfList = int.Parse(Console.ReadLine());

            int[] valueList = new int[numberOfList];

            int minValue = 0;

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


            int min = valueList[0];

            for (int i = 1; i < valueList.Length; i++)
            {             

                if (min > valueList[i])
                {
                    min = valueList[i];
                }
                minValue = min;
            }
            return minValue;
        }
    }
}
