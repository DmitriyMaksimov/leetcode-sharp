namespace leetcode_sharp;

// 3201. Find the Maximum Length of Valid Subsequence I
// https://leetcode.com/problems/find-the-maximum-length-of-valid-subsequence-i
public class S03201
{
    public int MaximumLength(int[] nums)
    {
        var expectedParity = nums[0] % 2;
        var oddCount = 0;
        var evenCount = 0;
        var alternatingCount = 0;

        foreach (var num in nums)
        {
            if (num % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }

            if (num % 2 == expectedParity)
            {
                alternatingCount++;
                expectedParity = 1 - expectedParity;
            }
        }

        return Math.Max(alternatingCount, Math.Max(evenCount, oddCount));
    }
}