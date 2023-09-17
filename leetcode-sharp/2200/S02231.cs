namespace leetcode_sharp;

// 2231. Largest Number After Digit Swaps by Parity
// https://leetcode.com/problems/largest-number-after-digit-swaps-by-parity/
public class S02231
{
    public int LargestInteger(int num)
    {
        var digits = num.ToString().Select(x => x - '0').ToArray();

        for (var i = 0; i < digits.Length - 1; i++)
        {
            for (var j = i + 1; j < digits.Length; j++)
            {
                if (digits[i] % 2 == digits[j] % 2 && digits[i] < digits[j])
                {
                    (digits[i], digits[j]) = (digits[j], digits[i]);
                }
            }
        }

        return int.Parse(new string(digits.Select(x => (char) (x + '0')).ToArray()));
    }
}