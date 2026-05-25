namespace leetcode_sharp;

// 1871. Jump Game VII
// https://leetcode.com/problems/jump-game-vii
public class S01871
{
    public bool CanReach(string s, int minJump, int maxJump)
    {
        var n = s.Length;
        var pre = 0;
        var dp = new bool[n];

        dp[0] = true;

        for (var i = 1; i < n; i++)
        {
            if (i >= minJump && dp[i - minJump])
            {
                pre++;
            }

            if (i > maxJump && dp[i - maxJump - 1])
            {
                pre--;
            }

            dp[i] = pre > 0 && s[i] == '0';
        }

        return dp[n - 1];
    }
}