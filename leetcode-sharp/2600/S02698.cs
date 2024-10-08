namespace leetcode_sharp;

// 2698. Find the Punishment Number of an Integer
// https://leetcode.com/problems/find-the-punishment-number-of-an-integer
public class S02698
{
    private readonly Dictionary<int, bool> _cache = [];

    public int PunishmentNumber(int n)
    {
        var result = 0;

        for (var i = 1; i <= n; ++i)
        {
            var square = i * i;
            var squareStr = square.ToString();

            if (!_cache.ContainsKey(square))
            {
                _cache[square] = Check(squareStr, i, 0);
            }

            result += square * (_cache[square] ? 1 : 0);
        }

        return result;
    }

    private static bool Check(string s, int r, int i)
    {
        var str = s[i..];
        var t = int.Parse(str);

        if (r > t || r < 0 || s.Length == i)
        {
            return false;
        }

        if (t == r)
        {
            return true;
        }

        for (var j = 1; i + j < s.Length; ++j)
        {
            str = s.Substring(i, j);
            if (Check(s, r - int.Parse(str), i + j))
            {
                return true;
            }
        }

        return false;
    }
}
