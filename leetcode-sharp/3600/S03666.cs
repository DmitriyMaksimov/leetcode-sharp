namespace leetcode_sharp;

// 3666. Minimum Operations to Equalize Binary String
// https://leetcode.com/problems/minimum-operations-to-equalize-binary-string
public class S03666
{
    public int MinOperations(string s, int k)
    {
        var zero = 0;
        var len = s.Length;

        for (var i = 0; i < len; i++)
        {
            zero += ~s[i] & 1;
        }

        if (zero == 0)
        {
            return 0;
        }

        if (len == k)
        {
            return ((zero == len ? 1 : 0) << 1) - 1;
        }

        var remainingLength = len - k;

        var odd = Math.Max(
            (zero + k - 1) / k,
            (len - zero + remainingLength - 1) / remainingLength
        );

        odd += ~odd & 1;

        var even = Math.Max(
            (zero + k - 1) / k,
            (zero + remainingLength - 1) / remainingLength
        );

        even += even & 1;

        var res = int.MaxValue;

        if ((k & 1) == (zero & 1))
        {
            res = Math.Min(res, odd);
        }

        if ((~zero & 1) == 1)
        {
            res = Math.Min(res, even);
        }

        return res == int.MaxValue ? -1 : res;
    }
}