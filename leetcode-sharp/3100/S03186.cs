namespace leetcode_sharp;

// 3186. Maximum Total Damage With Spell Casting
// https://leetcode.com/problems/maximum-total-damage-with-spell-casting
public class S03186
{
    public long MaximumTotalDamage(int[] power)
    {
        Array.Sort(power);

        var dp = new long[100001];
        var maxDp = 0L;
        var j = 0;

        for (var i = 0; i < power.Length; i++)
        {
            if (i > 0 && power[i] == power[i - 1])
            {
                dp[i + 1] = power[i] + dp[i];
            }
            else
            {
                while (j < i && power[j] + 2 < power[i])
                {
                    maxDp = Math.Max(maxDp, dp[++j]);
                }

                dp[i + 1] = power[i] + maxDp;
            }
        }

        return dp.Take(power.Length + 1).Max();
    }
}