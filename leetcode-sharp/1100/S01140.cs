namespace leetcode_sharp;

// 1140. Stone Game II
// https://leetcode.com/problems/stone-game-ii/
public class S01140
{
    private int[,,] _dp;
    private const int AliceTurn = 0;
    private const int BobTurn = 1;

    public int StoneGameII(int[] piles)
    {
        initDp(piles.Length);

        return stonesAliceGets(piles, AliceTurn, 0, 1);
    }

    private int stonesAliceGets(IReadOnlyList<int> piles, int turn, int startIndex, int m)
    {
        if (startIndex == piles.Count)
        {
            return 0;
        }

        if (_dp[turn, startIndex, m] != -1)
        {
            return _dp[turn, startIndex, m];
        }

        var answer = turn == BobTurn ? int.MaxValue : 0;
        var takenCount = 0;

        for (var x = 1; x <= Math.Min(2 * m, piles.Count - startIndex); x++)
        {
            takenCount += piles[startIndex + x - 1];

            var newM = Math.Max(m, x);

            if (turn == AliceTurn)
            {
                answer = Math.Max(answer, takenCount + stonesAliceGets(piles, BobTurn, startIndex + x, newM));
            }
            else
            {
                answer = Math.Min(answer, stonesAliceGets(piles, AliceTurn, startIndex + x, newM));
            }
        }

        return _dp[turn, startIndex, m] = answer;
    }

    private void initDp(int pilesLength)
    {
        _dp = new int[2, pilesLength + 1, pilesLength + 1];

        for (var startIndex = 0; startIndex <= pilesLength; startIndex++)
        {
            for (var m = 0; m <= pilesLength; m++)
            {
                _dp[AliceTurn, startIndex, m] = -1;
                _dp[BobTurn, startIndex, m] = -1;
            }
        }
    }
}