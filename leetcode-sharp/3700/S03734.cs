using System.Text;

namespace leetcode_sharp;

// 3734. Lexicographically Smallest Palindromic Permutation Greater Than Target
// https://leetcode.com/problems/lexicographically-smallest-palindromic-permutation-greater-than-target
public class S03734
{
    public string LexPalindromicPermutation(string s, string target)
    {
        var freq = new int[26];

        foreach (var t in s)
        {
            freq[t - 'a']++;
        }

        var center = '\0';

        for (var i = 0; i < 26; i++)
        {
            if (freq[i] % 2 != 0)
            {
                if (center != '\0')
                {
                    return "";
                }

                center = (char)('a' + i);
                freq[i]--;
            }
        }

        var sz = s.Length;
        var half = sz / 2;

        for (var i = 0; i < half; i++)
            freq[target[i] - 'a'] -= 2;

        if (Check(freq))
        {
            var head = target.Substring(0, half);
            var rev = new string(head.Reverse().ToArray());

            var tail = "";

            if (center != '\0')
            {
                tail += center;
            }

            tail += rev;

            if (string.Compare(tail, target.Substring(half), StringComparison.Ordinal) > 0)
            {
                return head + tail;
            }
        }

        for (var i = half - 1; i >= 0; i--)
        {
            var w = target[i];
            freq[w - 'a'] += 2;

            if (!Check(freq))
            {
                continue;
            }

            for (var j = (w - 'a') + 1; j < 26; j++)
            {
                if (freq[j] == 0)
                {
                    continue;
                }

                freq[j] -= 2;

                var answer = new StringBuilder(target[..(i + 1)])
                {
                    [i] = (char)('a' + j)
                };

                for (var k = 0; k < 26; k++)
                {
                    var cnt = freq[k] / 2;

                    for (var m = 0; m < cnt; m++)
                        answer.Append((char)('a' + k));
                }

                var part = new string(answer.ToString().Reverse().ToArray());

                if (center != '\0')
                {
                    answer.Append(center);
                }

                answer.Append(part);

                return answer.ToString();
            }
        }

        return "";
    }

    private static bool Check(int[] freq)
    {
        return freq.All(v => v >= 0);
    }
}