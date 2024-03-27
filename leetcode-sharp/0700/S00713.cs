namespace leetcode_sharp;

// 713. Subarray Product Less Than K
// https://leetcode.com/problems/subarray-product-less-than-k
public class S00713
{
    public int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        if (k == 0)
        {
            return 0;
        }

        var count = 0;
        var product = 1;

        for (int left = 0, right = 0; right < nums.Length; ++right)
        {
            product *= nums[right];
        
            while (left <= right && product >= k)
            {
                product /= nums[left++];
            }

            count += right - left + 1;
        }

        return count;
    }
}