namespace leetcode_sharp;

// 564. Find the Closest Palindrome
// https://leetcode.com/problems/find-the-closest-palindrome
public class S00564
{
    public string NearestPalindromic(string n)
    {
        var len = n.Length;
        var left = long.Parse(n[..((len + 1) / 2)]);

        List<long> candidates =
        [
            GetPalindrome(left, len % 2 == 0),
            GetPalindrome(left + 1, len % 2 == 0),
            GetPalindrome(left - 1, len % 2 == 0),
            (long)Math.Pow(10, len - 1) - 1,
            (long)Math.Pow(10, len) + 1
        ];

        var diff = long.MaxValue;
        long res = 0;
        var nl = long.Parse(n);

        foreach (var candidate in candidates)
        {
            if (candidate == nl)
            {
                continue;
            }

            if (Math.Abs(candidate - nl) < diff)
            {
                diff = Math.Abs(candidate - nl);
                res = candidate;
            }
            else if (Math.Abs(candidate - nl) == diff)
            {
                res = Math.Min(res, candidate);
            }
        }

        return res.ToString();
    }

    private static long GetPalindrome(long left, bool even)
    {
        var res = left;

        if (!even)
        {
            left /= 10;
        }

        while (left > 0)
        {
            res = res * 10 + left % 10;
            left /= 10;
        }

        return res;
    }
}
