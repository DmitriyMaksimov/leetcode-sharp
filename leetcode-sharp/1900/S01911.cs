namespace leetcode_sharp;

// 1911. Maximum Alternating Subsequence Sum
// https://leetcode.com/problems/maximum-alternating-subsequence-sum
public class S01911
{
    public long MaxAlternatingSum(int[] nums)
    {
        var odd = 0L;
        var even = 0L;

        foreach (var num in nums)
        {
            even = Math.Max(even, odd + num);
            odd = even - num;
        }

        return even;
    }
}
