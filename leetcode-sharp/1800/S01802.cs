namespace leetcode_sharp;

// 1802. Maximum Value at a Given Index in a Bounded Array
// https://leetcode.com/problems/maximum-value-at-a-given-index-in-a-bounded-array/
public class S01802
{
    public int MaxValue(int n, int index, int maxSum)
    {
        maxSum -= n;
        int left = 0, right = maxSum;
        while (left < right)
        {
            var mid = (left + right + 1) / 2;
            if (check(mid, index, n) <= maxSum)
            {
                left = mid;
            }
            else
            {
                right = mid - 1;
            }
        }

        return left + 1;
    }

    private static long check(long a, int index, int n)
    {
        var leftOffset = Math.Max(a - index, 0);
        var result = (a + leftOffset) * (a - leftOffset + 1) / 2;
        var rightOffset = Math.Max(a - ((n - 1) - index), 0);
        result += (a + rightOffset) * (a - rightOffset + 1) / 2;
        return result - a;
    }
}