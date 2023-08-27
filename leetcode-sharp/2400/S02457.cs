namespace leetcode_sharp;

// 2457. Minimum Addition to Make Integer Beautiful
// https://leetcode.com/problems/minimum-addition-to-make-integer-beautiful/
public class S02457
{
    public long MakeIntegerBeautiful(long n, int target)
    {
        var digits = new List<long>();
        var sum = 0L;

        for (var l = n; l > 0; l /= 10)
        {
            var digit = l % 10;
            digits.Add(digit);
            sum += digit;
        }

        for (var i = 0; i < digits.Count; i++)
        {
            if (sum <= target)
            {
                break;
            }

            sum -= digits[i];

            digits[i] = 0;
            
            if (i + 1 < digits.Count)
            {
                digits[i + 1]++;
            }
            else
            {
                digits.Add(1);
            }

            sum++;
        }

        return digits.AsEnumerable().Reverse().Aggregate<long, long>(0, (current, t) => current * 10 + t) - n;
    }
}