namespace leetcode_sharp;

// 3737. Count Subarrays With Majority Element I
// https://leetcode.com/problems/count-subarrays-with-majority-element-i
public class S03737
{
    public int CountMajoritySubarrays(int[] nums, int target)
    {
        var n = nums.Length;
        var offset = n + 1;
        var balance = offset;
        var result = 0;

        // frequency[b] = number of previous prefixes with balance b
        var frequency = new int[2 * n + 2];

        // cumulativeFrequency[b] = number of previous prefixes whose balance is <= b.
        var cumulativeFrequency = new int[2 * n + 2];

        frequency[balance] = 1;
        cumulativeFrequency[balance] = 1;

        foreach (var num in nums)
        {
            balance += num == target ? 1 : -1;

            frequency[balance]++;
            cumulativeFrequency[balance] = cumulativeFrequency[balance - 1] + frequency[balance];
            result += cumulativeFrequency[balance - 1];
        }

        return result;
    }
}