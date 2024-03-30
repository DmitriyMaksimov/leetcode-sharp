namespace leetcode_sharp;

// 992. Subarrays with K Different Integers
// https://leetcode.com/problems/subarrays-with-k-different-integers
public class S00992
{
    public int SubarraysWithKDistinct(int[] nums, int k)
    {
        var result = 0;
        var n = nums.Length;
        var counts = new int[n + 1];

        for (int left = 0, mid = 0, right = 0; right < n; ++right)
        {
            if (++counts[nums[right]] == 1)
            {
                if (--k < 0)
                {
                    counts[nums[mid++]] = 0;
                    left = mid;
                }
            }

            if (k <= 0)
            {
                while (counts[nums[mid]] > 1)
                {
                    --counts[nums[mid++]];
                }

                result += mid - left + 1;
            }
        }

        return result;
    }
}