namespace CSharpBasic
{
    public class Exe1
    {
        public void printFibonacciSeries()
        {

            //ex1
            Console.WriteLine("Input amount of the Fibonacci series: ");

            int amountTerms = int.Parse(s: Console.ReadLine());

            int firstTerm = 0;
            int secondTerm = 1;
            int nextTerm;
            Console.Write("Output: " + firstTerm + "  " + secondTerm + " ");

            for (int i = 0; i < amountTerms - 2; i++)
            {
                // 0 1 1 2 3 5 8 13 21 34

                nextTerm = firstTerm + secondTerm;
                Console.Write(" " + nextTerm + " ");

                firstTerm = secondTerm;
                secondTerm = nextTerm;
            }
        }
    }
}
