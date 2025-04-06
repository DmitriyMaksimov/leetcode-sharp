namespace leetcode_sharp;

// 3492. Maximum Containers on a Ship
// https://leetcode.com/problems/maximum-containers-on-a-ship
public class S03492
{
    public int MaxContainers(int n, int w, int maxWeight)
    {
        return Math.Min(n * n, maxWeight / w);
    }
}
