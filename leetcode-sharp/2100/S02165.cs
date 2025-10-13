using System.Globalization;

namespace leetcode_sharp;

// 2165. Smallest Value of the Rearranged Number
// https://leetcode.com/problems/smallest-value-of-the-rearranged-number
public class S02165
{
    public long SmallestNumber(long num)
    {
        var isNegative = num < 0;
        if (isNegative)
        {
            num = -num;
        }

        var digits = num.ToString(CultureInfo.InvariantCulture).ToArray();

        if (isNegative)
        {
            digits = digits.OrderDescending().ToArray();
        }
        else
        {
            digits = digits.Order().ToArray();

            if (digits[0] == '0')
            {
                for (var i = 1; i < digits.Length; i++)
                {
                    if (digits[i] == '0')
                    {
                        continue;
                    }

                    (digits[0], digits[i]) = (digits[i], digits[0]);
                    break;
                }
            }
        }

        return isNegative ? -long.Parse(digits) : long.Parse(digits);
    }
}
