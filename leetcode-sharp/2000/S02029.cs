namespace leetcode_sharp;

// 2029. Stone Game IX
// https://leetcode.com/problems/stone-game-ix
public class S02029
{
    public bool StoneGameIX(int[] stones)
    {
        var count = new int[3];

        foreach (var stone in stones)
        {
            count[stone % 3]++;
        }

        return Math.Min(count[1], count[2]) == 0 ? Math.Max(count[1], count[2]) > 2 && count[0] % 2 > 0 : Math.Abs(count[1] - count[2]) > 2 || count[0] % 2 == 0;
    }
}