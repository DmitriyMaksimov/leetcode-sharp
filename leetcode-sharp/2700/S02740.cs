namespace leetcode_sharp;

// 2740. Find the Value of the Partition
// https://leetcode.com/problems/find-the-value-of-the-partition
public class S02740
{
    public int FindValueOfPartition(int[] nums)
    {
        Array.Sort(nums);
        var res = nums[1] - nums[0];

        for (var i = 2; i < nums.Length; i++)
        {
            res = Math.Min(res, nums[i] - nums[i - 1]);
        }

        return res;
    }
}
