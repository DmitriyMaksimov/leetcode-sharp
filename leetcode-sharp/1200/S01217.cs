namespace leetcode_sharp;

// 1217. Minimum Cost to Move Chips to The Same Position
// https://leetcode.com/problems/minimum-cost-to-move-chips-to-the-same-position/
public class S01217
{
    public int MinCostToMoveChips(int[] position)
    {
        var odd = 0;
        var even = 0;

        foreach (var p in position)
        {
            if (p % 2 == 0)
            {
                even++;
            }
            else
            {
                odd++;
            }
        }

        return Math.Min(odd, even);
    }
}