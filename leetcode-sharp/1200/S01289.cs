namespace leetcode_sharp;

// 1289. Minimum Falling Path Sum II
// https://leetcode.com/problems/minimum-falling-path-sum-ii
public class S01289
{
    public int MinFallingPathSum(int[][] grid)
    {
        var fm = 0;
        var sm = 0;
        var pos = -1;

        foreach (var val in grid)
        {
            var fm2 = int.MaxValue;
            var sm2 = int.MaxValue;
            var pos2 = -1;

            for (var j = 0; j < val.Length; ++j)
            {
                var mn = j != pos ? fm : sm;
                if (val[j] + mn < fm2)
                {
                    sm2 = fm2;
                    fm2 = val[j] + mn;
                    pos2 = j;
                }
                else
                {
                    sm2 = Math.Min(sm2, val[j] + mn);
                }
            }

            fm = fm2;
            sm = sm2;
            pos = pos2;
        }

        return fm;
    }
}