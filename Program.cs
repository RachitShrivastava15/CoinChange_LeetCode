namespace CoinChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coins = {1,2,5};
            int amount = 11;
            int result = CoinChange(coins, amount);
            Console.WriteLine(result);

        }

        static int CoinChange(int[] coins, int amount)
        {
            int[] d = new int[amount + 1];

            for(int i = 1; i <= amount; i++)
            {
                d[i] = int.MaxValue;
                for(int j = 0; j < coins.Length; j++)
                {                
                    if(i >= coins[j] && d[i - coins[j]] != int.MaxValue)
                    {
                        d[i] = Math.Min(d[i], 1 + d[i - coins[j]]);
                    }
                }
            }

            return d[amount] == int.MaxValue ? -1 : d[amount];
        }
    }
}