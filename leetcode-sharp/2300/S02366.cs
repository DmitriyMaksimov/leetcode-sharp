namespace leetcode_sharp;

// 2366. Minimum Replacements to Sort the Array
// https://leetcode.com/problems/minimum-replacements-to-sort-the-array/
public class S02366
{
    public long MinimumReplacement(int[] nums)
    {
        var n = nums.Length;
        var prev = nums[n - 1];
        var ans = 0L;
        for (var i = n - 2; i >= 0; i--)
        {
            var noOfTime = nums[i] / prev;

            if (nums[i] % prev != 0)
            {
                noOfTime++;
                prev = nums[i] / noOfTime;
            }

            ans += noOfTime - 1;
        }

        return ans;
    }
}