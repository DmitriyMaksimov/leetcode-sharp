namespace leetcode_sharp;

// 2081. Sum of k-Mirror Numbers
// https://leetcode.com/problems/sum-of-k-mirror-numbers
public class S02081
{
    public long KMirror(int k, int n)
    {
        long sum = 0;
        for (var len = 1L; n > 0; len *= 10)
        {
            for (var i = len; n > 0 && i < len * 10; i++)
            {
                var p = CreatePalindrome(i, true);
                if (IsPalindrome(p, k))
                {
                    sum += p;
                    n--;
                }
            }

            for (var i = len; n > 0 && i < len * 10; i++)
            {
                var p = CreatePalindrome(i, false);
                if (IsPalindrome(p, k))
                {
                    sum += p;
                    n--;
                }
            }
        }

        return sum;
    }

    private static long CreatePalindrome(long num, bool odd)
    {
        var x = odd ? num / 10 : num;
        while (x > 0)
        {
            num = num * 10 + x % 10;
            x /= 10;
        }

        return num;
    }

    private static bool IsPalindrome(long num, int b)
    {
        Span<byte> digits = stackalloc byte[64];
        var length = 0;

        while (num > 0)
        {
            digits[length++] = (byte)(num % b);
            num /= b;
        }

        var left = 0;
        var right = length - 1;
        while (left < right)
        {
            if (digits[left++] != digits[right--])
                return false;
        }

        return true;
    }
}