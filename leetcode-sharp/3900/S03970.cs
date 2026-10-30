namespace leetcode_sharp;

// 3970. Shortest Path With At Most K Consecutive Identical Characters
// https://leetcode.com/problems/shortest-path-with-at-most-k-consecutive-identical-characters
public class S03970
{
    public int ShortestPath(int n, int[][] edges, string labels, int k)
    {
        var graph = new List<(int node, int weight)>[n];

        for (var i = 0; i < n; i++)
        {
            graph[i] = new List<(int, int)>();
        }

        foreach (var edge in edges)
        {
            graph[edge[0]].Add((edge[1], edge[2]));
        }

        var best = Enumerable.Repeat(k + 1, n).ToArray();

        var pq = new PriorityQueue<(int d, int run, int node), (int d, int run)>();

        pq.Enqueue((0, 1, 0), (0, 1));

        while (pq.Count > 0)
        {
            var (d, run, x) = pq.Dequeue();

            if (run >= best[x])
            {
                continue;
            }

            if (x == n - 1)
            {
                return d;
            }

            best[x] = run;

            foreach (var (y, w) in graph[x])
            {
                var r = labels[y] == labels[x] ? run + 1 : 1;

                if (r < best[y])
                {
                    pq.Enqueue((d + w, r, y), (d + w, r));
                }
            }
        }

        return -1;
    }
}