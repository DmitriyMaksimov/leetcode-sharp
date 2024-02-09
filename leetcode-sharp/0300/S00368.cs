namespace leetcode_sharp;

// 368. Largest Divisible Subset
// https://leetcode.com/problems/largest-divisible-subset
public class S00368
{
    public IList<int> LargestDivisibleSubset(int[] nums)
    {
        var n = nums.Length;
        var dp = new int[n];
        Array.Fill(dp, 1);
        Array.Sort(nums);

        var maxSize = 1;
        var maxIndex = 0;

        for (var i = 1; i < n; i++)
        {
            for (var j = 0; j < i; j++)
            {
                if (nums[i] % nums[j] == 0)
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                    if (dp[i] > maxSize)
                    {
                        maxSize = dp[i];
                        maxIndex = i;
                    }
                }
            }
        }

        var result = new List<int>();
        var num = nums[maxIndex];
        for (var i = maxIndex; i >= 0; i--)
        {
            if (num % nums[i] == 0 && dp[i] == maxSize)
            {
                result.Add(nums[i]);
                num = nums[i];
                maxSize--;
            }
        }

        return result;
    }
}