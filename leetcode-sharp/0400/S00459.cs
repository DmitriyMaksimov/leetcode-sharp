using System.Text;

namespace leetcode_sharp;

// 459. Repeated Substring Pattern
// https://leetcode.com/problems/repeated-substring-pattern/
public class S00459
{
    public bool RepeatedSubstringPattern(string s)
    {
        var n = s.Length;
        for (var i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                var found = true;
                var substring = s.AsSpan(0, i);
                for (var j = 1; j < n / i; j++)
                {
                    if (!substring.SequenceEqual(s.AsSpan(j * i, i)))
                    {
                        found = false;
                        break;
                    }
                }

                if (found) return true;
            }
        }

        return false;
    }
}