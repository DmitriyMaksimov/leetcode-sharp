namespace leetcode_sharp;

// 594. Longest Harmonious Subsequence
// https://leetcode.com/problems/longest-harmonious-subsequence/
public class S00594
{
    public int FindLHS(int[] nums)
    {
        var dict = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            dict[num] = dict.GetValueOrDefault(num, 0) + 1;
        }

        var max = 0;

        foreach (var key in dict.Keys)
        {
            if (dict.ContainsKey(key + 1))
            {
                max = Math.Max(max, dict[key] + dict[key + 1]);
            }
        }

        return max;
    }
}