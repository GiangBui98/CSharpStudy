// See https://aka.ms/new-console-template for more information

using CSharpBasic;
using System.Data;

namespace Datatype
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exe1
            /* Exe1 exe1 = new Exe1();
             exe1.printFibonacciSeries();*/

            //Exe2
            /*Exe2 exe2 = new Exe2();
            exe2.sum();*/

            //Exe3 --> not done
            /*Exe3 exe3 = new Exe3();
            int result = exe3.findTheSmallestNumber();
            Console.WriteLine(result);*/

            //Exe4 --> incorrect result
            /*Exe4 exe4 = new Exe4();
            bool result = exe4.checkSquareNumbers();
            if (result)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }*/

            //Exe5 
            Exe5 exe5 = new Exe5();
            bool result = exe5.checkPrimeNumber();
            if (result)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }

}



