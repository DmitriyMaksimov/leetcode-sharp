namespace leetcode_sharp;

// 1510. Stone Game IV
// https://leetcode.com/problems/stone-game-iv
public class S01510
{
    public bool WinnerSquareGame(int n)
    {
        var dp = new bool[n + 1];

        for (var i = 1; i <= n; i++)
        {
            for (var j = 1; j * j <= i; j++)
            {
                if (!dp[i - j * j])
                {
                    dp[i] = true;
                    break;
                }
            }
        }

        return dp[n];
    }
}