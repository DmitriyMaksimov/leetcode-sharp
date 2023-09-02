namespace leetcode_sharp;

// 598. Range Addition II
// https://leetcode.com/problems/range-addition-ii
public class S00598
{
    public int MaxCount(int m, int n, int[][] ops)
    {
        var minM = m;
        var minN = n;

        foreach (var op in ops)
        {
            minM = Math.Min(minM, op[0]);
            minN = Math.Min(minN, op[1]);
        }

        return minM * minN;
    }
}