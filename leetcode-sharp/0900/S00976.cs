namespace leetcode_sharp;

// 976. Largest Perimeter Triangle
// https://leetcode.com/problems/largest-perimeter-triangle/
public class S00976
{
    public int LargestPerimeter(int[] nums)
    {
        Array.Sort(nums);

        for (var i = nums.Length - 1; i >= 2; i--)
        {
            if (nums[i - 2] + nums[i - 1] > nums[i])
            {
                return nums[i - 2] + nums[i - 1] + nums[i];
            }
        }

        return 0;
    }
}