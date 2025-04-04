namespace leetcode_sharp;

// 1033. Moving Stones Until Consecutive
// https://leetcode.com/problems/moving-stones-until-consecutive
public class S01033
{
    public int[] NumMovesStones(int a, int b, int c)
    {
        var stones = new[] { a, b, c }.Order().ToArray();

        var x = stones[0];
        var y = stones[1];
        var z = stones[2];

        int minSteps;

        if (x + 1 == y && y + 1 == z)
        {
            minSteps = 0;
        }
        else if (y - x > 2 && z - y > 2)
        {
            minSteps = 2;
        }
        else
        {
            minSteps = 1;
        }

        var maxSteps = z - x - 2;

        return [minSteps, maxSteps];
    }
}
