using System.Text;

namespace leetcode_sharp;

// 3518. Smallest Palindromic Rearrangement II
// https://leetcode.com/problems/smallest-palindromic-rearrangement-ii
public class S03518
{
    public string SmallestPalindrome(string s, int k)
    {
        var freq = new int[26];
        foreach (var c in s)
        {
            freq[c - 'a']++;
        }

        var half = new int[26];
        var mid = new StringBuilder();
        var m = 0;

        for (var i = 0; i < 26; i++)
        {
            if ((freq[i] & 1) != 0)
            {
                mid.Append((char)(i + 'a'));
            }

            half[i] = freq[i] / 2;
            m += half[i];
        }

        if (GetWays(half, k) < k)
        {
            return "";
        }

        var firstHalf = new StringBuilder();

        for (var i = 0; i < m; i++)
        {
            for (var c = 0; c < 26; c++)
            {
                if (half[c] <= 0)
                {
                    continue;
                }

                half[c]--;

                var ways = GetWays(half, k);

                if (ways >= k)
                {
                    firstHalf.Append((char)(c + 'a'));
                    break;
                }

                k -= (int)ways;
                half[c]++;
            }
        }

        var left = firstHalf.ToString();
        var reversed = left.ToCharArray();
        Array.Reverse(reversed);

        return left + mid + new string(reversed);
    }

    private long GetWays(int[] f, long targetK)
    {
        var ways = 1L;
        var currLen = 0;

        foreach (var count in f)
        {
            if (count <= 0)
            {
                continue;
            }

            currLen += count;

            long n = currLen;
            long r = count;

            if (r > n - r)
            {
                r = n - r;
            }

            long curNCr = 1;

            for (long i = 1; i <= r; i++)
            {
                curNCr = curNCr * (n - i + 1) / i;

                if (curNCr > targetK)
                {
                    curNCr = targetK + 1;
                    break;
                }
            }

            ways *= curNCr;

            if (ways > targetK)
            {
                return targetK + 1;
            }
        }

        return ways;
    }
}