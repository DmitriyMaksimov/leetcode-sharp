namespace leetcode_sharp;

// 960. Delete Columns to Make Sorted III
// https://leetcode.com/problems/delete-columns-to-make-sorted-iii
public class S00960
{
    public int MinDeletionSize(string[] strs)
    {
        var n = strs.Length;
        var m = strs[0].Length;

        var dp = new int[m];
        for (var j = 0; j < m; j++)
        {
            dp[j] = 1;
        }

        var maxKeep = 1;
        for (var j = 0; j < m; j++)
        {
            for (var i = 0; i < j; i++)
            {
                var valid = true;
                for (var r = 0; r < n; r++)
                {
                    if (strs[r][i] > strs[r][j])
                    {
                        valid = false;
                        break;
                    }
                }

                if (valid)
                {
                    dp[j] = Math.Max(dp[j], dp[i] + 1);
                }
            }

            maxKeep = Math.Max(maxKeep, dp[j]);
        }

        return m - maxKeep;
    }
}