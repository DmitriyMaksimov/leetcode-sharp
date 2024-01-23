namespace leetcode_sharp;

// 3010. Divide an Array Into Subarrays With Minimum Cost I
// https://leetcode.com/problems/divide-an-array-into-subarrays-with-minimum-cost-i
public class S03010
{
    public int MinimumCost(int[] nums)
    {
        var n1 = nums[1];
        var n2 = nums[2];

        for (var i = 3; i < nums.Length; i++)
        {
            
            if (nums[i] <= n1 || nums[i] <= n2)
            {
                n1 = Math.Min(n1, n2);
                n2 = nums[i];
            }
        }

        return nums[0] + n1 + n2;
    }
}