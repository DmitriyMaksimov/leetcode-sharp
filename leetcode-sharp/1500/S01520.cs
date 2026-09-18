namespace leetcode_sharp;

// 1520. Maximum Number of Non-Overlapping Substrings
// https://leetcode.com/problems/maximum-number-of-non-overlapping-substrings
public class S01520
{
    public IList<string> MaxNumOfSubstrings(string s)
    {
        var left = new int[26];
        var right = new int[26];

        Array.Fill(left, s.Length);

        var result = new List<string>();

        for (var i = 0; i < s.Length; ++i)
        {
            var ch = s[i] - 'a';
            left[ch] = Math.Min(left[ch], i);
            right[ch] = i;
        }

        var rightIndex = -1;

        for (var i = 0; i < s.Length; ++i)
        {
            if (i == left[s[i] - 'a'])
            {
                var newRight = CheckSubstr(s, i, left, right);

                if (newRight != -1)
                {
                    if (i > rightIndex)
                    {
                        result.Add("");
                    }

                    rightIndex = newRight;
                    result[^1] = s.Substring(i, rightIndex - i + 1);
                }
            }
        }

        return result;
    }

    private static int CheckSubstr(string s, int i, int[] l, int[] r)
    {
        var right = r[s[i] - 'a'];

        for (var j = i; j <= right; ++j)
        {
            if (l[s[j] - 'a'] < i)
            {
                return -1;
            }

            right = Math.Max(right, r[s[j] - 'a']);
        }

        return right;
    }
}