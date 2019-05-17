using System;
using System.Collections.Generic;

namespace CoinChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Coins = { 1, 2, 5, 10, 20, 50 };
            int change = 47;
            Console.WriteLine("Hello, this is coin change calculator");
            Console.WriteLine("Available coins: {0}", string.Join(", ", Coins));
            Console.WriteLine("Change to be made: {0}", change);
            makeChangeGreedy(Coins, change);

            Console.WriteLine(string.Join(", ", Coins));
        }

        public static void makeChangeGreedy(int[] coinsTemp, int change)
        {
            int[] coins = new int[coinsTemp.Length];

            Array.Copy(coinsTemp, coins, coins.Length);
            Array.Sort(coins);
            Array.Reverse(coins);

            List<string> change_list = new List<string>();

            foreach (int coin in coins)
            {
                int how_many = change / coin;

                if (how_many > 0)
                {
                    change_list.Add(how_many + "x" + coin);
                }

                change = change % coin;
            }

            Console.WriteLine(string.Join(", ", change_list.ToArray()));
        }

        public static void makeChangeDynamic(int[] arrCoins, int change)
        {
            int[] coins = new int[arrCoins.Length];
            Array.Copy(arrCoins, coins, arrCoins.Length);
            Array.Sort(coins);

            int[] minCoins = new int[change + 1];
            int[] firstCoinIndex = new int[change + 1];

            for (int currChange = 0; currChange < change + 1; currChange++)
            {
                int coinCount = currChange;
                int newCoin = 0;

                foreach(int coin in coins)
                {
                    if (coin > currChange)
                    {
                        continue;
                        
                    }
                    if (1 + minCoins[currChange - coin] < coinCount)
                    {
                        coinCount = 1 + minCoins[currChange - coin];
                        newCoin = coin;
                    }

                }
                minCoins[currChange] = coinCount;
                firstCoinIndex[currChange] = newCoin;
                
            }
        }
    }
}
