namespace leetcode_sharp;

// 3272. Find the Count of Good Integers
// https://leetcode.com/problems/find-the-count-of-good-integers
public class S03272
{
    public long CountGoodIntegers(int n, int k)
    {
        if (n == 1)
        {
            return 9 / k;
        }

        var digits = Enumerable.Range(0, 10).Select(i => i.ToString()).ToArray();
        var kPals = new HashSet<string>();
        var result = 0L;

        var palsLeft = GetProducts(n, digits);

        foreach (var palLeft in palsLeft)
        {
            var palRight = new string(palLeft.Reverse().ToArray()).Substring(n % 2);
            var pal = string.Concat(palLeft + palRight);

            if (long.Parse(pal) % k == 0)
            {
                var sorted = string.Concat(pal.Order());
                kPals.Add(sorted);
            }
        }

        foreach (var kPal in kPals)
        {
            var count = new Dictionary<char, int>();
            foreach (var ch in kPal)
            {
                count[ch] = count.GetValueOrDefault(ch) + 1;
            }

            var denom = (long)1;
            foreach (var val in count.Values)
            {
                denom *= Factorial(val);
            }

            var zeros = count.GetValueOrDefault('0', 0);
            var numerator = Factorial(n) * (n - zeros);
            var combo = numerator / (denom * n);
            result += combo;
        }

        return (int)result;
    }

    private static List<string> GetProducts(int n, string[] digits)
    {
        var results = new List<string>();
        var half = (n + 1) / 2;

        Backtrack("", 0);
        return results;

        void Backtrack(string current, int pos)
        {
            if (pos == half)
            {
                results.Add(current);
                return;
            }

            var possibleDigits = (pos == 0) ? digits.Skip(1) : digits;
            foreach (var d in possibleDigits)
            {
                Backtrack(current + d, pos + 1);
            }
        }
    }

    private static long Factorial(int x)
    {
        var res = (long)1;
        for (var i = 2; i <= x; i++)
        {
            res *= i;
        }

        return res;
    }
}
