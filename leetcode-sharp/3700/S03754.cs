namespace leetcode_sharp;

// 3754. Concatenate Non-Zero Digits and Multiply by Sum I
// https://leetcode.com/problems/concatenate-non-zero-digits-and-multiply-by-sum-i
public class S03754
{
    public long SumAndMultiply(int n)
    {
        if (n == 0) return 0;

        var strN = n.ToString().ToArray();
        var skipZerosStr = strN.Where(c => c != '0').ToArray();
        var sum = skipZerosStr.Select(c => (long)(c - '0')).Sum();
        var skipZeroN = long.Parse(skipZerosStr);

        return sum * skipZeroN;
    }
}