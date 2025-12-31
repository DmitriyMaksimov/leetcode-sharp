namespace leetcode_sharp;

// 3560. Find Minimum Log Transportation Cost
// https://leetcode.com/problems/find-minimum-log-transportation-cost
public class S03560
{
    public long MinCuttingCost(int n, int m, int k)
    {
        long longest = Math.Max(n, m);

        if (longest <= k)
        {
            return 0;
        }

        return k * (longest - k);
    }
}