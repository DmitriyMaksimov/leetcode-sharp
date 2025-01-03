namespace leetcode_sharp;

// 2270. Number of Ways to Split Array
// https://leetcode.com/problems/number-of-ways-to-split-array
public class S02270
{
    public int WaysToSplitArray(int[] nums)
    {
        var sumFromBack = nums.Select(x => (long)x).Sum();
        long sumFromFront = 0;
        var result = 0;

        for (var i = 0; i < nums.Length - 1; i++)
        {
            sumFromFront += nums[i];
            sumFromBack -= nums[i];

            if (sumFromFront >= sumFromBack)
            {
                ++result;
            }
        }

        return result;
    }
}
