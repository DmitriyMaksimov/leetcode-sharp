namespace leetcode_sharp;

// 2563. Count the Number of Fair Pairs
// https://leetcode.com/problems/count-the-number-of-fair-pairs
public class S02563
{
    public long CountFairPairs(int[] nums, int lower, int upper)
    {
        Array.Sort(nums);
        return Count(nums, upper) - Count(nums, lower - 1);
    }

    private static long Count(int[] nums, int val)
    {
        var res = 0L;
        var i = 0;
        var j = nums.Length - 1;

        while (i < j)
        {
            if (nums[i] + nums[j] <= val)
            {
                res += j - i;
                i++;
            }
            else
            {
                j--;
            }
        }

        return res;
    }
}
