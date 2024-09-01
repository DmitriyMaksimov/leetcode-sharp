namespace leetcode_sharp;

// 2640. Find the Score of All Prefixes of an Array
// https://leetcode.com/problems/find-the-score-of-all-prefixes-of-an-array
public class S02640
{
    public long[] FindPrefixScore(int[] nums)
    {
        var n = nums.Length;
        var result = new long[n];
        var min = 0;

        for (var i = 0; i < n; i++)
        {
            if (min <= nums[i])
            {
                min = nums[i];
            }

            result[i] += min + nums[i];
        }

        for (var i = 1; i < n; i++)
        {
            result[i] += result[i - 1];
        }

        return result;
    }
}
