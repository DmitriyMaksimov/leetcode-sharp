namespace leetcode_sharp;

// 1071. Greatest Common Divisor of Strings
// https://leetcode.com/problems/greatest-common-divisor-of-strings/
public class S01071
{
    public string GcdOfStrings(string str1, string str2)
    {
        var gcd = "";
        
        for (var i = 0; i < Math.Min(str1.Length, str2.Length); i++)
        {
            if (str1[i] != str2[i]) break;
            gcd += str1[i];
        }

        while (gcd.Length > 0)
        {
            if (divides(gcd, str1) && divides(gcd, str2))
            {
                break;
            }
            gcd = gcd[..^1];
        }
        
        return gcd;
    }

    private static bool divides(string t, string s)
    {
        if (s.Length % t.Length != 0) return false;

        return string.Concat(Enumerable.Repeat(t, s.Length / t.Length)) == s;
    }
}