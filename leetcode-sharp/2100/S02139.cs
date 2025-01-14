namespace leetcode_sharp;

// 2139. Minimum Moves to Reach Target Score
// https://leetcode.com/problems/minimum-moves-to-reach-target-score
public class S02139
{
    public int MinMoves(int target, int maxDoubles)
    {
        var result = 0;

        while (target > 1 && maxDoubles-- > 0)
        {
            result += target % 2 + 1;
            target /= 2;
        }

        return result + target - 1;
    }
}
