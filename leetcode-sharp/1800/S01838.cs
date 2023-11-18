namespace leetcode_sharp;

// 1838. Frequency of the Most Frequent Element
// https://leetcode.com/problems/frequency-of-the-most-frequent-element/
public class S01838
{
    public int MaxFrequency(int[] nums, int k)
    {
        var maxFrequency = 0;
        var currentSum = 0L;

        Array.Sort(nums);

        for (int left = 0, right = 0; right < nums.Length; ++right)
        {
            currentSum += nums[right];

            while (currentSum + k < (long) nums[right] * (right - left + 1))
            {
                currentSum -= nums[left];
                left++;
            }

            maxFrequency = Math.Max(maxFrequency, right - left + 1);
        }

        return maxFrequency;
    }
}