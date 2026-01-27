namespace leetcode_sharp;

// 3650. Minimum Cost Path with Edge Reversals
// https://leetcode.com/problems/minimum-cost-path-with-edge-reversals
public class S03650
{
    public int MinCost(int n, int[][] edges)
    {
        List<(int to, int cost)>[] graph = new List<(int, int)>[n];
        for (var i = 0; i < n; i++)
        {
            graph[i] = [];
        }

        foreach (var e in edges)
        {
            var u = e[0];
            var v = e[1];
            var w = e[2];
            graph[u].Add((v, w));
            graph[v].Add((u, w * 2));
        }

        const long inf = long.MaxValue / 2;
        var dist = Enumerable.Repeat(inf, n).ToArray();
        dist[0] = 0;

        var priorityQueue = new PriorityQueue<(long d, int node), long>();
        priorityQueue.Enqueue((0, 0), 0);

        while (priorityQueue.Count > 0)
        {
            var (currentDist, u) = priorityQueue.Dequeue();

            if (currentDist > dist[u])
            {
                continue;
            }

            foreach (var (v, cost) in graph[u])
            {
                var newDist = currentDist + cost;
                if (newDist < dist[v])
                {
                    dist[v] = newDist;
                    priorityQueue.Enqueue((newDist, v), newDist);
                }
            }
        }

        return dist[n - 1] == inf ? -1 : (int)dist[n - 1];
    }
}