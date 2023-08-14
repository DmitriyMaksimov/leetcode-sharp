namespace leetcode_sharp;

// 724. Find Pivot Index
// https://leetcode.com/problems/find-pivot-index/
public class S00724
{
    public int PivotIndex(int[] nums)
    {
        var totalSum = nums.Sum();

        for (int i = 0, leftSum = 0; i < nums.Length; ++i)
        {
            if (leftSum * 2 == totalSum - nums[i])
            {
                return i;
            }

            leftSum += nums[i];
        }

        return -1;
    }
}