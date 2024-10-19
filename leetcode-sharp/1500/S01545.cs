namespace leetcode_sharp;

// 1545. Find Kth Bit in Nth Binary String
// https://leetcode.com/problems/find-kth-bit-in-nth-binary-string
public class S01545
{
    public char FindKthBit(int n, int k)
    {
        if (n == 1)
        {
            return '0';
        }

        var len = (int)Math.Pow(2, n) - 1;

        if (k - 1 == len / 2)
        {
            return '1';
        }

        return k - 1 < len / 2 ? FindKthBit(n - 1, k) : FindKthBit(n - 1, len - k + 1) == '0' ? '1' : '0';
    }
}
