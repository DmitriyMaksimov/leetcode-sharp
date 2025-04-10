namespace leetcode_sharp;

// 915. Partition Array into Disjoint Intervals
// https://leetcode.com/problems/partition-array-into-disjoint-intervals
public class S00915
{
    public int PartitionDisjoint(int[] nums)
    {
        var localMax = nums[0];
        var partitionIndex = 0;
        var max = localMax;

        for (var i = 1; i < nums.Length; i++)
        {
            if (localMax > nums[i])
            {
                localMax = max;
                partitionIndex = i;
            }
            else
            {
                max = Math.Max(max, nums[i]);
            }
        }

        return partitionIndex + 1;
    }
}
