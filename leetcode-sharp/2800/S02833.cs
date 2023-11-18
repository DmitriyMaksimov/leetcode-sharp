namespace leetcode_sharp;

// 2833. Furthest Point From Origin
// https://leetcode.com/problems/furthest-point-from-origin
public class S02833
{
    public int FurthestDistanceFromOrigin(string moves)
    {
        var leftCount = 0;
        var rightCount = 0;
        var bothCount = 0;

        foreach (var move in moves)
        {
            switch (move)
            {
                case 'L':
                    leftCount++;
                    break;
                case 'R':
                    rightCount++;
                    break;
                default:
                    bothCount++;
                    break;
            }
        }

        return Math.Abs(leftCount - rightCount) + bothCount;
    }
}