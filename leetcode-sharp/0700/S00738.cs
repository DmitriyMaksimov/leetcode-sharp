namespace leetcode_sharp;

// 738. Monotone Increasing Digits
// https://leetcode.com/problems/monotone-increasing-digits
public class S00738
{
    public int MonotoneIncreasingDigits(int n)
    {
        var digits = n.ToString().ToCharArray();
        var monotoneEnd = digits.Length - 1;

        for (var i = digits.Length - 1; i > 0; i--)
        {
            if (digits[i] < digits[i - 1])
            {
                monotoneEnd = i - 1;
                digits[i - 1]--;
            }
        }

        for (var i = monotoneEnd + 1; i < digits.Length; i++)
        {
            digits[i] = '9';
        }

        return int.Parse(digits);
    }
}
