namespace leetcode_sharp;

// 1829. Maximum XOR for Each Query
// https://leetcode.com/problems/maximum-xor-for-each-query
public class S01829
{
    public int[] GetMaximumXor(int[] nums, int maximumBit)
    {
        var n = nums.Length;
        var result = new int[n];
        var xor = nums.Aggregate(0, (current, num) => current ^ num);

        result[0] = xor ^= (1 << maximumBit) - 1;

        for (var i = 1; i < n; i++)
        {
            result[i] = xor ^= nums[n - i];
        }

        return result;
    }
}