
namespace CSharpBasic
{
    public class Exe10
    {
        public int MaxValue()
        {
            Console.Write("Input number 1 = ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Input number 2 = ");
            int number2 = int.Parse(Console.ReadLine());
            Console.Write("Input number 3 = ");
            int number3 = int.Parse(Console.ReadLine());

            int result1 = number1 * number2 * number3;
            int result2 = (number1 + number2) * number3;
            int result3 = number1 + (number2 * number3);

            List<int> results = new List<int>();
            results.Add(result1);
            results.Add(result2);
            results.Add(result3);

            /*foreach (int result in results)
            { 
                Console.WriteLine(result);
            }*/

            int max = results[0];
            int maxValue = 0;

            for (int i = 1; i < results.Count; i++)
            {

                if (max < results[i])
                {
                    max = results[i];
                }
                maxValue = max;
            }

            return maxValue;
        }
    }
}
