using System.Text;

namespace leetcode_sharp;

// 2182. Construct String With Repeat Limit
// https://leetcode.com/problems/construct-string-with-repeat-limit
public class S02182
{
    public string RepeatLimitedString(string s, int repeatLimit)
    {
        var count = new int[26];
        var result = new StringBuilder();

        foreach (var c in s)
        {
            count[c - 'a']++;
        }

        while (true)
        {
            var i = 25;
            var onlyOne = false;

            for (; i >= 0; --i)
            {
                if (result.Length > 0 && i == result[^1] - 'a' && count[i] > 0)
                {
                    onlyOne = true;
                    continue;
                }

                if (count[i] > 0)
                {
                    break;
                }
            }

            if (i == -1)
            {
                break;
            }

            var fill = onlyOne ? 1 : Math.Min(count[i], repeatLimit);
            count[i] -= fill;

            while (fill-- > 0)
            {
                result.Append((char)('a' + i));
            }
        }

        return result.ToString();
    }
}
