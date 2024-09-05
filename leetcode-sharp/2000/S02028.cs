namespace leetcode_sharp;

// 2028. Find Missing Observations
// https://leetcode.com/problems/find-missing-observations
public class S02028
{
    public int[] MissingRolls(int[] rolls, int mean, int n)
    {
        var curSum = rolls.Sum();
        var m = rolls.Length;
        var missingSum = mean * (n + m) - curSum;

        if (missingSum < n || missingSum > 6 * n)
        {
            return [];
        }

        var part = missingSum / n;
        var reminder = missingSum % n;

        var ans = new int[n];

        Array.Fill(ans, part);

        for (var i = 0; i < reminder; ++i)
        {
            ++ans[i];
        }

        return ans;
    }
}
