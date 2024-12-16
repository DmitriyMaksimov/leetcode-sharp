namespace leetcode_sharp;

// 795. Number of Subarrays with Bounded Maximum
// https://leetcode.com/problems/number-of-subarrays-with-bounded-maximum
public class S00795
{
    public int NumSubarrayBoundedMax(int[] nums, int left, int right)
    {
        return Count(nums, right) - Count(nums, left - 1);
    }

    private static int Count(int[] nums, int bound)
    {
        var result = 0;
        var count = 0;

        foreach (var num in nums)
        {
            count = num <= bound ? count + 1 : 0;
            result += count;
        }

        return result;
    }
}
