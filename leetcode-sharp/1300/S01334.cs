namespace leetcode_sharp;

// 1334. Find the City With the Smallest Number of Neighbors at a Threshold Distance
// https://leetcode.com/problems/find-the-city-with-the-smallest-number-of-neighbors-at-a-threshold-distance
public class S01334
{
    public int FindTheCity(int n, int[][] edges, int distanceThreshold)
    {
        var dis = new int[n][];
        var res = 0;
        var smallest = n;

        for (var i = 0; i < n; i++)
        {
            dis[i] = new int[n];
            Array.Fill(dis[i], 10001);
        }
        
        foreach (var edge in edges)
        {
            dis[edge[0]][edge[1]] = dis[edge[1]][edge[0]] = edge[2];
        }

        for (var i = 0; i < n; ++i)
        {
            dis[i][i] = 0;
        }

        for (var k = 0; k < n; ++k)
        {
            for (var i = 0; i < n; ++i)
            {
                for (var j = 0; j < n; ++j)
                {
                    dis[i][j] = Math.Min(dis[i][j], dis[i][k] + dis[k][j]);
                }
            }
        }

        for (var i = 0; i < n; i++)
        {
            var count = 0;

            for (var j = 0; j < n; ++j)
            {
                if (dis[i][j] <= distanceThreshold)
                    ++count;
            }

            if (count <= smallest)
            {
                res = i;
                smallest = count;
            }
        }

        return res;
    }
}