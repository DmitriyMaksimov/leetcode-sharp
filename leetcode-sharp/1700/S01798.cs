namespace leetcode_sharp;

// 1798. Maximum Number of Consecutive Values You Can Make
// https://leetcode.com/problems/maximum-number-of-consecutive-values-you-can-make
public class S01798
{
    public int GetMaximumConsecutive(int[] coins)
    {
        Array.Sort(coins);

        var result = 1;

        for (var i = 0; i < coins.Length && coins[i] <= result; ++i)
        {
            result += coins[i];
        }

        return result;
    }
}
