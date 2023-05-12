namespace leetcode_sharp;

// 2140. Solving Questions With Brainpower
// https://leetcode.com/problems/solving-questions-with-brainpower/
public class S02140
{
    public long MostPoints(int[][] questions)
    {
        var dp = new long[100_000 + questions.Length + 1];
        for (var i = questions.Length - 1; i >= 0; --i)
        {
            dp[i] = Math.Max(questions[i][0] + dp[questions[i][1] + i + 1], dp[i + 1]);
        }

        return dp[0];
    }
}