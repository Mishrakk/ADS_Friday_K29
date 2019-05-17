using System;

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
            
            
        }
    }
}
