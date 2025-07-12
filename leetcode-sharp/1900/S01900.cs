using System.Numerics;

namespace leetcode_sharp;

// 1900. The Earliest and Latest Rounds Where Players Compete
// https://leetcode.com/problems/the-earliest-and-latest-rounds-where-players-compete 
public class S01900
{
    public int[] EarliestAndLatest(int n, int firstPlayer, int secondPlayer)
    {
        if (firstPlayer + secondPlayer == n + 1)
        {
            return [1, 1];
        }

        if (firstPlayer + secondPlayer > n + 1)
        {
            var tmpFirst = n + 1 - secondPlayer;
            var tmpSecond = n + 1 - firstPlayer;
            firstPlayer = tmpFirst;
            secondPlayer = tmpSecond;
        }

        var earliestRound = 1;
        var latestRound = Math.Min(32 - BitOperations.LeadingZeroCount((uint)(n - 1)), n + 1 - secondPlayer);

        if (firstPlayer + secondPlayer == n)
        {
            if (firstPlayer % 2 == 0)
            {
                earliestRound = firstPlayer + 2 < secondPlayer ? 2 : 1 + BitOperations.TrailingZeroCount((uint)firstPlayer);
            }
        }
        else if (firstPlayer + 1 == secondPlayer)
        {
            var k = (n - 1) / (firstPlayer + secondPlayer - 1);
            var clz = 32 - BitOperations.LeadingZeroCount((uint)k);
            var tz = BitOperations.TrailingZeroCount((uint)((n - 1) >> clz));
            earliestRound = clz + tz;
        }
        else if (firstPlayer + secondPlayer <= (n + 1) / 2)
        {
            var k = (n - 1) / (firstPlayer + secondPlayer - 1);
            earliestRound = 32 - BitOperations.LeadingZeroCount((uint)k);
        }

        return [earliestRound + 1, latestRound];
    }
}