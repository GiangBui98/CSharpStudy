using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    public class Exe5
    {
        public bool checkPrimeNumber()
        {
            Console.WriteLine("Input a number");
            int number = int.Parse(Console.ReadLine());

            if (number <= 1)
            {
                return false;
            } 
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
