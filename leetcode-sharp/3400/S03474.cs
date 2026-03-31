using System.Text;

namespace leetcode_sharp;

// 3474. Lexicographically Smallest Generated String
// https://leetcode.com/problems/lexicographically-smallest-generated-string
public class S03474
{
    public string GenerateString(string str1, string str2)
    {
        var n = str1.Length;
        var m = str2.Length;
        var l = n + m - 1;
        var word = new char?[l];

        for (var i = 0; i < n; i++)
        {
            if (str1[i] != 'T')
            {
                continue;
            }

            for (var j = 0; j < m; j++)
            {
                var pos = i + j;
                if (word[pos] != null && word[pos] != str2[j])
                {
                    return "";
                }

                word[pos] = str2[j];
            }
        }

        var free = new bool[l];
        for (var i = 0; i < l; i++)
        {
            if (word[i] == null)
            {
                word[i] = 'a';
                free[i] = true;
            }
        }

        if (n == 0)
        {
            return new string('a', l);
        }

        for (var i = 0; i < n; i++)
        {
            if (str1[i] == 'F' && IntervalEquals(word, str2, i, m))
            {
                var fixedFlag = false;
                for (var j = m - 1; j >= 0; j--)
                {
                    var pos = i + j;
                    if (free[pos])
                    {
                        word[pos] = 'b';
                        free[pos] = false;
                        fixedFlag = true;
                        break;
                    }
                }

                if (!fixedFlag)
                {
                    return "";
                }
            }
        }

        return new string(word.Select(c => c.Value).ToArray());
    }

    private static bool IntervalEquals(char?[] word, string str2, int i, int m)
    {
        for (var j = 0; j < m; j++)
        {
            if (word[i + j] == null || word[i + j] != str2[j])
            {
                return false;
            }
        }

        return true;
    }
}