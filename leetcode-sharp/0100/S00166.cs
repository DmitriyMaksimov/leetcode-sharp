using System.Text;

namespace leetcode_sharp;

// 166. Fraction to Recurring Decimal
// https://leetcode.com/problems/fraction-to-recurring-decimal
public class S00166
{
    public string FractionToDecimal(int numerator, int denominator)
    {
        if (numerator == 0)
        {
            return "0";
        }

        var sb = new StringBuilder();

        if ((numerator > 0) ^ (denominator > 0))
        {
            sb.Append('-');
        }

        var num = Math.Abs((long)numerator);
        var den = Math.Abs((long)denominator);

        sb.Append(num / den);
        num %= den;

        if (num == 0)
        {
            return sb.ToString();
        }

        sb.Append('.');
        var map = new Dictionary<long, int>
        {
            [num] = sb.Length
        };

        while (num != 0)
        {
            num *= 10;
            sb.Append(num / den);
            num %= den;

            if (map.TryGetValue(num, out var index))
            {
                sb.Insert(index, "(");
                sb.Append(')');
                break;
            }

            map[num] = sb.Length;
        }

        return sb.ToString();
    }
}