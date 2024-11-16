namespace leetcode_sharp;

// 2952. Minimum Number of Coins to be Added
// https://leetcode.com/problems/minimum-number-of-coins-to-be-added
public class S02952
{
    public int MinimumAddedCoins(int[] coins, int target)
    {
        Array.Sort(coins);

        var currentSum = 0L;
        var addedCoins = 0;

        foreach (var coin in coins)
        {
            while (currentSum + 1 < coin && currentSum + 1 <= target)
            {
                currentSum += currentSum + 1;
                addedCoins++;
            }

            if (currentSum >= target)
            {
                break;
            }

            currentSum += coin;
        }

        while (currentSum < target)
        {
            currentSum += currentSum + 1;
            addedCoins++;
        }

        return addedCoins;
    }
}
