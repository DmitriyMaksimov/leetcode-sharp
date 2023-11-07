namespace leetcode_sharp;

// 1921. Eliminate Maximum Number of Monsters
// https://leetcode.com/problems/eliminate-maximum-number-of-monsters
public class S01921
{
    public int EliminateMaximum(int[] dist, int[] speed)
    {
        var n = dist.Length;
        var timeToCity = new double[n];

        for (var i = 0; i < n; i++)
        {
            timeToCity[i] = (double) dist[i] / speed[i];
        }

        Array.Sort(timeToCity);

        for (var i = 0; i < n; i++)
        {
            if (timeToCity[i] <= i)
            {
                return i;
            }
        }

        return n;
    }
}