namespace leetcode_sharp;

// 2222. Number of Ways to Select Buildings
// https://leetcode.com/problems/number-of-ways-to-select-buildings
public class S02222
{
    public long NumberOfWays(string s)
    {
        var one = 0L;
        var zero = 0L;
        var oneZero = 0L;
        var zeroOne = 0L;
        var result = 0L;

        foreach (var c in s)
        {
            if (c == '0')
            {
                zero++;
                oneZero += one;
                result += zeroOne;
            }
            else
            {
                one++;
                zeroOne += zero;
                result += oneZero;
            }
        }

        return result;
    }
}
