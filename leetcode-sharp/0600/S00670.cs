namespace leetcode_sharp;

// 670. Maximum Swap
// https://leetcode.com/problems/maximum-swap
public class S00670
{
    public int MaximumSwap(int num)
    {
        var digits = num.ToString().ToCharArray();
        var buckets = new int[10];

        for (var i = 0; i < digits.Length; i++)
        {
            buckets[digits[i] - '0'] = i;
        }

        for (var i = 0; i < digits.Length; i++)
        {
            for (var k = 9; k > digits[i] - '0'; k--)
            {
                if (buckets[k] <= i) continue;

                (digits[i], digits[buckets[k]]) = (digits[buckets[k]], digits[i]);
                return int.Parse(new string(digits));
            }
        }

        return num;
    }
}
