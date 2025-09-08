namespace leetcode_sharp;

// 1317. Convert Integer to the Sum of Two No-Zero Integers
// https://leetcode.com/problems/convert-integer-to-the-sum-of-two-no-zero-integers/
public class S01317
{
    public int[] GetNoZeroIntegers(int n)
    {
        for (var i = 1; i < n; i++)
        {
            if (HasNoZero(i) && HasNoZero(n - i))
            {
                return [i, n - i];
            }
        }

        return [];
    }

    private static bool HasNoZero(int n)
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