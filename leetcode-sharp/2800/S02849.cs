namespace leetcode_sharp;

// 2849. Determine if a Cell Is Reachable at a Given Time
// https://leetcode.com/problems/determine-if-a-cell-is-reachable-at-a-given-time
public class S02849
{
    public bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t)
    {
        var xDistance = Math.Abs(sx - fx);
        var yDistance = Math.Abs(sy - fy);
        var minDist = Math.Min(xDistance, yDistance) + Math.Abs(yDistance - xDistance);

        if (minDist == 0)
        {
            return t != 1;
        }

        return t >= minDist;
    }
}