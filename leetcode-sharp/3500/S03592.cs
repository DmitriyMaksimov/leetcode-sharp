namespace leetcode_sharp;

// 3592. Inverse Coin Change
// https://leetcode.com/problems/inverse-coin-change
public class S03592
{
    public IList<int> FindCoins(int[] numWays)
    {
        var n = numWays.Length;
        var myWays = new long[n + 1];
        myWays[0] = 1;

        var result = new List<int>();

        for (var i = 1; i <= n; i++)
        {
            if (myWays[i] == numWays[i - 1])
            {
                continue;
            }

            if (numWays[i - 1] - myWays[i] != 1)
            {
                return [];
            }

            result.Add(i);
            for (var j = i; j <= n; j++)
            {
                myWays[j] += myWays[j - i];
            }
        }

        return result;
    }
}