﻿namespace leetcode_sharp;

// 322. Coin Change
// https://leetcode.com/problems/coin-change/
public class S00322
{
    public int CoinChange(int[] coins, int amount)
    {
        if (amount == 0)
        {
            return 0;
        }

        var dp = new int[amount + 1];
        Array.Fill(dp, int.MaxValue - 1);

        dp[0] = 0;

        for (var i = 1; i <= amount; i++)
        {
            foreach (var coin in coins)
            {
                if (coin <= i)
                {
                    dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                }
            }
        }

        return dp[amount] > amount ? -1 : dp[amount];
    }
}