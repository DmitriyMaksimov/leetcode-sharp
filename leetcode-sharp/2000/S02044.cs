namespace leetcode_sharp;

// 2044. Count Number of Maximum Bitwise-OR Subsets
// https://leetcode.com/problems/count-number-of-maximum-bitwise-or-subsets
public class S02044
{
    public int CountMaxOrSubsets(int[] nums)
    {
        var max = 0;
        var dp = new int[1 << 17];
        dp[0] = 1;
        
        foreach (var num in nums)
        {
            for (var i = max; i >= 0; --i)
            {
                dp[i | num] += dp[i];
            }

            max |= num;
        }

        return dp[max];
    }
}