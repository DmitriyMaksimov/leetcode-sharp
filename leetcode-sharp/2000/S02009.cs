namespace leetcode_sharp;

// 2009. Minimum Number of Operations to Make Array Continuous
// https://leetcode.com/problems/minimum-number-of-operations-to-make-array-continuous
public class S02009
{
    public int MinOperations(int[] nums)
    {
        var n = nums.Length;
        Array.Sort(nums);
        var numberOfUniqElements = 1;

        // Remove duplicate elements in the sorted array
        for (var i = 1; i < n; ++i)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[numberOfUniqElements++] = nums[i];
            }
        }

        var ans = n;

        // Use a sliding window
        for (int i = 0, j = 0; i < numberOfUniqElements; ++i)
        {
            while (j < numberOfUniqElements && nums[j] - nums[i] <= n - 1)
            {
                ++j;
            }

            ans = Math.Min(ans, n - (j - i));
        }

        return ans;
    }
}