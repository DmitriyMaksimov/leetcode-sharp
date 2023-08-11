namespace leetcode_sharp;

// 238. Product of Array Except Self
// https://leetcode.com/problems/product-of-array-except-self/
public class S00238
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var n = nums.Length;
        var ans = new int[n];
        for (var i = 0; i < n; ++i)
        {
            ans[i] = 1;
        }

        int leftProduct = 1, rightProduct = 1;
        for (int i = 1, j = n - 2; i < n; ++i, --j)
        {
            leftProduct *= nums[i - 1];
            rightProduct *= nums[j + 1];

            ans[i] *= leftProduct;
            ans[j] *= rightProduct;
        }

        return ans;
    }
}