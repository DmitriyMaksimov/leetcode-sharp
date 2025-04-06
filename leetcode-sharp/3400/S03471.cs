namespace leetcode_sharp;

// 3471. Find the Largest Almost Missing Integer
// https://leetcode.com/problems/find-the-largest-almost-missing-integer
public class S03471
{
    public int LargestInteger(int[] nums, int k)
    {
        var freq = new Dictionary<int, int>();
        foreach (var n in nums)
        {
            freq[n] = freq.GetValueOrDefault(n) + 1;
        }

        var result = -1;
        var uniqueLargest = -1;
        var largest = -1;

        foreach (var num in nums)
        {
            if (freq[num] == 1)
            {
                uniqueLargest = Math.Max(uniqueLargest, num);
            }

            largest = Math.Max(largest, num);
        }

        if (k == 1)
        {
            return uniqueLargest;
        }

        if (k == nums.Length)
        {
            return largest;
        }

        if (freq[nums[0]] == 1)
        {
            result = Math.Max(result, nums[0]);
        }

        if (freq[nums[^1]] == 1)
        {
            result = Math.Max(result, nums[^1]);
        }

        return result;
    }
}
