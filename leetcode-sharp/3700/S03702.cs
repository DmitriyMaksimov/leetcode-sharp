namespace leetcode_sharp;

// 3702. Longest Subsequence With Non-Zero Bitwise XOR
// https://leetcode.com/problems/longest-subsequence-with-non-zero-bitwise-xor
public class S03702
{
    public int LongestSubsequence(int[] nums)
    {
        var total = 0;
        var n = nums.Length;
        var containNonZero = false;

        foreach (var num in nums)
        {
            containNonZero |= num != 0;
            total ^= num;
        }

        if (!containNonZero)
        {
            return 0;
        }

        return total == 0 ? n - 1 : n;
    }
}