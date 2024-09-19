namespace leetcode_sharp;

// 973. K Closest Points to Origin
// https://leetcode.com/problems/k-closest-points-to-origin
public class S00973
{
    public int[][] KClosest(int[][] points, int k)
    {
        Array.Sort(points, (p1, p2) => p1[0] * p1[0] + p1[1] * p1[1] - p2[0] * p2[0] - p2[1] * p2[1]);
        return points.Take(k).ToArray();
    }
}
