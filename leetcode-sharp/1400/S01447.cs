namespace leetcode_sharp;

// 1447. Simplified Fractions
// https://leetcode.com/problems/simplified-fractions
public class S01447
{
    public IList<string> SimplifiedFractions(int n)
    {
        List<string> ans = [];

        for (var denominator = 2; denominator <= n; ++denominator)
        {
            for (var numerator = 1; numerator < denominator; ++numerator)
            {
                if (Gcd(numerator, denominator) == 1)
                {
                    ans.Add($"{numerator}/{denominator}");
                }
            }
        }

        return ans;
    }

    private static int Gcd(int x, int y)
    {
        return x == 0 ? y : Gcd(y % x, x);
    }
}
