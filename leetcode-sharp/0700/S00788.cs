namespace leetcode_sharp;

// 788. Rotated Digits
// https://leetcode.com/problems/rotated-digits
public class S00788
{
    public int RotatedDigits(int n)
    {
        var dp = new int[n + 1];
        var result = 0;

        for (var i = 0; i <= n; i++)
        {
            if (i < 10)
            {
                if (i is 0 or 1 or 8)
                {
                    dp[i] = 1;
                }
                else if (i is 2 or 5 or 6 or 9)
                {
                    dp[i] = 2;
                    result++;
                }
            }
            else
            {
                var a = dp[i / 10];
                var b = dp[i % 10];

                if (a == 1 && b == 1)
                {
                    dp[i] = 1;
                }
                else if (a >= 1 && b >= 1)
                {
                    dp[i] = 2;
                    result++;
                }
            }
        }

        return result;
    }
}
