namespace leetcode_sharp;

// 1663. Smallest String With A Given Numeric Value
// https://leetcode.com/problems/smallest-string-with-a-given-numeric-value
public class S01663
{
    public string GetSmallestString(int n, int k)
    {
        var res = new char[n];
        Array.Fill(res, 'a');
        k -= n;

        while (k > 0)
        {
            res[--n] += (char)Math.Min(25, k);
            k -= Math.Min(25, k);
        }

        return new string(res);
    }
}
