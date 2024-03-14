namespace leetcode_sharp;

// 930. Binary Subarrays With Sum
// https://leetcode.com/problems/binary-subarrays-with-sum
public class S00930
{
    public int NumSubarraysWithSum(int[] nums, int goal)
    {
        var prefixSum = 0;
        var result = 0;
        var count = new int[nums.Length + 1];
        count[0] = 1;

        foreach (var num in nums)
        {
            prefixSum += num;

            if (prefixSum >= goal)
            {
                result += count[prefixSum - goal];
            }

            count[prefixSum]++;
        }

        return result;
    }
}