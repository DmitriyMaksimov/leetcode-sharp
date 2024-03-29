namespace leetcode_sharp;

// 2294. Partition Array Such That Maximum Difference Is K
// https://leetcode.com/problems/partition-array-such-that-maximum-difference-is-k
public class S02294
{
    public int PartitionArray(int[] nums, int k)
    {
        Array.Sort(nums);
        
        var result = 1;
        var min = nums[0];
        var max = nums[0];

        foreach (var num in nums)
        {
            min = Math.Min(min, num);
            max = Math.Max(max, num);

            if (max - min > k)
            {
                result++;
                min = max = num;
            }
        }

        return result;
    }
}