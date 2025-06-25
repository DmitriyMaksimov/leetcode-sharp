namespace leetcode_sharp;

// 2040. Kth Smallest Product of Two Sorted Arrays
// https://leetcode.com/problems/kth-smallest-product-of-two-sorted-arrays
public class S02040
{
    public long KthSmallestProduct(int[] nums1, int[] nums2, long k)
    {
        var left = -10_000_000_000L;
        var right = 10_000_000_000L;

        while (left < right)
        {
            var mid = left + (right - left) / 2;
        
            if (CountProducts(nums1, nums2, mid) < k)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return left;
    }

    private static long CountProducts(int[] nums1, int[] nums2, long target)
    {
        var count = 0L;

        foreach (var num1 in nums1)
        {
            if (num1 == 0)
            {
                if (target >= 0)
                {
                    count += nums2.Length;
                }

                continue;
            }

            var low = 0;
            var high = nums2.Length;

            while (low < high)
            {
                var mid = low + (high - low) / 2;
                var product = (long)num1 * nums2[mid];

                if (product <= target)
                {
                    if (num1 > 0)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid;
                    }
                }
                else
                {
                    if (num1 > 0)
                    {
                        high = mid;
                    }
                    else
                    {
                        low = mid + 1;
                    }
                }
            }

            count += num1 > 0 ? low : nums2.Length - low;
        }

        return count;
    }
}