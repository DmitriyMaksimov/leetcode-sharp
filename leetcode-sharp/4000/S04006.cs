namespace leetcode_sharp;

// 4006. Count Valid Prefixes
// https://leetcode.com/problems/count-valid-prefixes
public class S04006
{
    public int CountValidPrefixes(string s)
    {
        var result = 0;
        var zeroCount = 0;
        var oneCount = 0;

        foreach (var ch in s)
        {
            if (ch == '0')
            {
                zeroCount++;
            }
            else
            {
                oneCount++;
            }

            if (Math.Abs(zeroCount - oneCount) <= 1)
            {
                ++result;
            }
        }

        return result;
    }
}