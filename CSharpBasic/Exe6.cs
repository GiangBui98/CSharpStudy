using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    public class Exe6
    {
        public void PlayCardGame()
        {
            char[] cardRanks = new char[] { '1', '2', '3' , '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A' };   

            int[] rankValues = cardRanks.Select(c => MapCardRankToInt(c)).ToArray();

            int[] shuffledRank = Shuffle(rankValues);

            foreach (int value in shuffledRank)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine("Rules: 0 < number of deals < 8");
            Console.Write("Enter number of deals: ");
            int numberOfDeals = int.Parse(Console.ReadLine());

            while (numberOfDeals < 0 || numberOfDeals > 8)
            {
                Console.Write("Invalid! Please enter valid number of deals: ");
                numberOfDeals = int.Parse(Console.ReadLine());

            }      

            int[] player1 = new int[numberOfDeals];
            int[] player2 = new int[numberOfDeals];

            int player1Index = 0, player2Index = 0;

            for (int i = 0; i < numberOfDeals * 2; i++)
            {
                if (i % 2 == 0)
                {
                    player1[player1Index] = shuffledRank[i];
                    player1Index++;
                }
                else
                {
                    player2[player2Index] = shuffledRank[i];
                    player2Index++;
                }
            }

            // Print 
            Console.Write("Player 1 cards: ");
            foreach (int value in player1)
            {
                Console.Write(value + "  ");
            }
            Console.WriteLine();

            Console.Write("Player 2 cards: ");
            foreach (int value in player2)
            {
                Console.Write(value + "  ");
            }

            //Compare
            int player1Count = 0, player2Count = 0;
            for(int i = 0; i < numberOfDeals; i++)
            {
                if (player1[i] > player2[i])
                {
                    player1Count++;

                }
                else
                {
                    player2Count++;
                }
            }
            Console.WriteLine();
            if(player1Count > player2Count)
            {
                Console.WriteLine("Player 1 won!");
            } 
            else if (player2Count == player1Count)
            {
                Console.WriteLine("Win - Win!");
            } 
            else
            {
                Console.WriteLine("Player 2 won!");

            }

        }
        static int[] Shuffle(int[] array)
        {
            Random rand = new Random();
            int[] shuffledArray = (int[])array.Clone();

            for (int i = shuffledArray.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                // Swap elements
                int temp = shuffledArray[i];
                shuffledArray[i] = shuffledArray[j];
                shuffledArray[j] = temp;
            }

            return shuffledArray;
        }
        static int MapCardRankToInt(char rank)
        {
            switch (rank)
            {
                case '2': return 2;
                case '3': return 3;
                case '4': return 4;
                case '5': return 5;
                case '6': return 6;
                case '7': return 7;
                case '8': return 8;
                case '9': return 9;
                case 'T': return 10;
                case 'J': return 11;
                case 'Q': return 12;
                case 'K': return 13;
                case 'A': return 14;
                default: return 0;
            }
        }
    }
}
