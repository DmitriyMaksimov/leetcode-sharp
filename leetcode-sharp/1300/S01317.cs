namespace leetcode_sharp;

// 1317. Convert Integer to the Sum of Two No-Zero Integers
// https://leetcode.com/problems/convert-integer-to-the-sum-of-two-no-zero-integers/
public class S01317
{
    public int[] GetNoZeroIntegers(int n)
    {
        for (var i = 1; i < n; i++)
        {
            if (hasNoZero(i) && hasNoZero(n - i))
            {
                return new[] {i, n - i};
            }
        }

        return Array.Empty<int>();
    }

    private static bool hasNoZero(int n)
    {
        while (n > 0)
        {
            if (n % 10 == 0)
            {
                return false;
            }

            n /= 10;
        }

        return true;
    }
}