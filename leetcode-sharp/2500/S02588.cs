namespace leetcode_sharp;

// 2588. Count the Number of Beautiful Subarrays
// https://leetcode.com/problems/count-the-number-of-beautiful-subarrays
public class S02588
{
    public long BeautifulSubarrays(int[] nums)
    {
        Dictionary<int, int> dp = [];
        dp[0] = 1;
        var prefixXor = 0;
        var res = 0L;

        foreach (var num in nums)
        {
            prefixXor ^= num;
            dp[prefixXor] = dp.GetValueOrDefault(prefixXor) + 1;
            res += dp[prefixXor] - 1;
        }

        return res;
    }
}
