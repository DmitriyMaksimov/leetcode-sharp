namespace leetcode_sharp;

// 3713. Longest Balanced Substring I
// https://leetcode.com/problems/longest-balanced-substring-i
public class S03713
{
    public int LongestBalanced(string s)
    {
        var n = s.Length;
        var result = 0;

        for (var i = 0; i < n; i++)
        {
            var freq = new int[26];
            var distinct = 0;

            for (var j = i; j < n; j++)
            {
                var idx = s[j] - 'a';

                if (freq[idx] == 0)
                {
                    distinct++;
                }

                freq[idx]++;

                if (IsAllEqual(freq, distinct))
                {
                    result = Math.Max(result, j - i + 1);
                }
            }
        }

        return result;
    }

    private static bool IsAllEqual(int[] freq, int distinct)
    {
        var expected = 0;
        var seen = 0;

        foreach (var f in freq)
        {
            if (f == 0)
            {
                continue;
            }

            if (expected == 0)
            {
                expected = f;
            }
            else if (f != expected)
            {
                return false;
            }

            seen++;
        }

        return seen == distinct;
    }
}