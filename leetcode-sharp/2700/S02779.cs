namespace leetcode_sharp;

// 2779. Maximum Beauty of an Array After Applying Operation
// https://leetcode.com/problems/maximum-beauty-of-an-array-after-applying-operation
public class S02779
{
    public int MaximumBeauty(int[] nums, int k)
    {
        Array.Sort(nums);
        var i = 0;
        var j = 0;

        for (; j < nums.Length; ++j)
        {
            if (nums[j] - nums[i] > k * 2)
            {
                i++;
            }
        }

        return j - i;
    }
}
