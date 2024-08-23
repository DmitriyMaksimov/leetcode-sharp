namespace leetcode_sharp;

// 592. Fraction Addition and Subtraction
// https://leetcode.com/problems/fraction-addition-and-subtraction
public class S00592
{
    public string FractionAddition(string expression)
    {
        var fractions = expression.Replace("+", " +").Replace("-", " -").Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var numerator = 0;
        var denominator = 1;

        foreach (var num in fractions)
        {
            var parts = num.Split('/');
            var a = int.Parse(parts[0]);
            var b = int.Parse(parts[1]);

            numerator = numerator * b + denominator * a;
            denominator *= b;

            var divisor = Gcd(Math.Abs(numerator), denominator);
            numerator /= divisor;
            denominator /= divisor;
        }

        return $"{numerator}/{denominator}";
    }

    private static int Gcd(int i, int j)
    {
        while (j != 0)
        {
            var temp = j;
            j = i % j;
            i = temp;
        }

        return i;
    }
}
