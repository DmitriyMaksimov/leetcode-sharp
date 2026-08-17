namespace leetcode_sharp;

// 1563. Stone Game V
// https://leetcode.com/problems/stone-game-v/description
public class S01563
{
    public int StoneGameV(int[] stoneValue)
    {
        var n = stoneValue.Length;
        var dp = new int[n, n];
        var max = new int[n, n];

        for (var i = 0; i < n; i++)
        {
            max[i, i] = stoneValue[i];
        }

        for (var j = 1; j < n; j++)
        {
            var mid = j;
            var sum = stoneValue[j];
            var rightHalf = 0;

            for (var i = j - 1; i >= 0; i--)
            {
                sum += stoneValue[i];

                while ((rightHalf + stoneValue[mid]) * 2 <= sum)
                {
                    rightHalf += stoneValue[mid--];
                }

                dp[i, j] = rightHalf * 2 == sum
                    ? max[i, mid]
                    : (mid == i ? 0 : max[i, mid - 1]);

                dp[i, j] = Math.Max(dp[i, j], mid == j ? 0 : max[j, mid + 1]);
                max[i, j] = Math.Max(max[i, j - 1], dp[i, j] + sum);
                max[j, i] = Math.Max(max[j, i + 1], dp[i, j] + sum);
            }
        }

        return dp[0, n - 1];
    }
}