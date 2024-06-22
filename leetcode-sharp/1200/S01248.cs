namespace leetcode_sharp;

// 1248. Count Number of Nice Subarrays
// https://leetcode.com/problems/count-number-of-nice-subarrays
public class S01248
{
    public int NumberOfSubarrays(int[] nums, int k)
    {
        return AtMost(nums, k) - AtMost(nums, k - 1);
    }

    private static int AtMost(int[] nums, int k)
    {
        var res = 0;
        var i = 0;
        var n = nums.Length;

        for (var j = 0; j < n; j++)
        {
            k -= nums[j] % 2;

            while (k < 0)
            {
                k += nums[i++] % 2;
            }

            res += j - i + 1;
        }

        return res;
    }
}