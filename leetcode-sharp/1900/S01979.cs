namespace leetcode_sharp;

// 1979. Find Greatest Common Divisor of Array
// https://leetcode.com/problems/find-greatest-common-divisor-of-array/
public class S01979
{
    public int FindGCD(int[] nums)
    {
        var min = nums[0];
        var max = nums[0];
        foreach (var num in nums)
        {
            max = Math.Max(max, num);
            min = Math.Min(min, num);
        }

        return gcd(min, max);
    }

    private static int gcd(int a, int b)
    {
        return b == 0 ? a : gcd(b, a % b);
    }
}