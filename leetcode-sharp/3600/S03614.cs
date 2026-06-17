namespace leetcode_sharp;

// 3614. Process String with Special Operations II
// https://leetcode.com/problems/process-string-with-special-operations-ii
public class S03614
{
    public char ProcessStr(string s, long k)
    {
        var len = 0L;

        foreach (var c in s)
        {
            if (char.IsLower(c))
            {
                len++;
            }
            else if (c == '*' && len > 0)
            {
                len--;
            }
            else if (c == '#')
            {
                len *= 2;
            }
        }

        if (k >= len)
        {
            return '.';
        }

        for (var i = s.Length - 1; i >= 0; i--)
        {
            var c = s[i];

            if (char.IsLower(c))
            {
                if (k == len - 1)
                {
                    return c;
                }

                len--;
            }
            else if (c == '*')
            {
                len++;
            }
            else if (c == '#')
            {
                len /= 2;

                if (k >= len)
                {
                    k -= len;
                }
            }
            else if (c == '%')
            {
                k = len - 1 - k;
            }
        }

        return '.';
    }
}