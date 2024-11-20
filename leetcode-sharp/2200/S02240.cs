namespace leetcode_sharp;

// 2240. Number of Ways to Buy Pens and Pencils
// https://leetcode.com/problems/number-of-ways-to-buy-pens-and-pencils
public class S02240
{
    public long WaysToBuyPensPencils(int total, int cost1, int cost2)
    {
        var result = 0L;

        for (int cnt = 0; cnt * cost1 <= total; ++cnt)
        {
            result += (total - cnt * cost1) / cost2 + 1;
        }

        return result;
    }
}
