namespace leetcode_sharp;

// 816. Ambiguous Coordinates
// https://leetcode.com/problems/ambiguous-coordinates
public class S00816
{
    public IList<string> AmbiguousCoordinates(string s)
    {
        var n = s.Length;
        var result = new List<string>();

        for (var i = 1; i < n - 2; ++i)
        {
            var x = ParseCoordinates(s.Substring(1, i));
            var y = ParseCoordinates(s.Substring(i + 1, n - i - 2));

            result.AddRange(x.SelectMany(_ => y, (a, b) => $"({a}, {b})"));
        }

        return result;
    }

    private List<string> ParseCoordinates(string s)
    {
        var n = s.Length;
        var res = new List<string>();

        switch (n)
        {
            case 0:
            case > 1 when s[0] == '0' && s[^1] == '0':
                return res;
            case > 1 when s[0] == '0':
                res.Add("0." + s[1..]);
                return res;
        }

        res.Add(s);

        if (n == 1 || s[^1] == '0')
        {
            return res;
        }

        for (var i = 1; i < n; ++i)
        {
            res.Add(s[..i] + "." + s[i..]);
        }

        return res;
    }
}
