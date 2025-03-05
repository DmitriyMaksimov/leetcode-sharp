namespace leetcode_sharp;

// 1968. Array With Elements Not Equal to Average of Neighbors
// https://leetcode.com/problems/array-with-elements-not-equal-to-average-of-neighbors
public class S01968
{
    public int[] RearrangeArray(int[] nums)
    {
        var order = nums[0] < nums[1];

        for (var i = 1; i < nums.Length - 1; i++)
        {
            if ((order && nums[i] < nums[i + 1]) || (!order && nums[i] > nums[i + 1]))
            {
                (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
            }

            order = !order;
        }

        return nums;
    }
}
