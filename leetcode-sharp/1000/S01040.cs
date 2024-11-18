namespace leetcode_sharp;

// 1040. Moving Stones Until Consecutive II
// https://leetcode.com/problems/moving-stones-until-consecutive-ii
public class S01040
{
    public int[] NumMovesStonesII(int[] stones)
    {
        Array.Sort(stones);
        var n = stones.Length;
        var i = 0;
        var low = n;

        var high = Math.Max(stones[n - 1] - n + 2 - stones[1], stones[n - 2] - stones[0] - n + 2);

        for (var j = 0; j < n; ++j)
        {
            while (stones[j] - stones[i] >= n)
            {
                ++i;
            }

            if (j - i + 1 == n - 1 && stones[j] - stones[i] == n - 2)
            {
                low = Math.Min(low, 2);
            }
            else
            {
                low = Math.Min(low, n - (j - i + 1));
            }
        }

        return [low, high];
    }
}
