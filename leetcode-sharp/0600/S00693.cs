namespace leetcode_sharp;

// 693. Binary Number with Alternating Bits
// https://leetcode.com/problems/binary-number-with-alternating-bits/
public class S00693
{
    public bool HasAlternatingBits(int n)
    {
        var s = Convert.ToString(n, 2);

        for (var i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                return false;
            }
        }

        return true;
    }
}