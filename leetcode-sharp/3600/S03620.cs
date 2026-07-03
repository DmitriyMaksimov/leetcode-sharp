namespace leetcode_sharp;

// 3620. Network Recovery Pathways
// https://leetcode.com/problems/network-recovery-pathways
public class S03620
{
    public int FindMaxPathScore(int[][] edges, bool[] online, long k)
    {
        var n = online.Length;
        var low = 0L;
        var high = 1_000_000_000L;
        var best = -1L;

        while (low <= high)
        {
            var threshold = low + (high - low) / 2;

            var graph = Enumerable.Range(0, n)
                .Select(_ => new List<(int To, int Cost)>())
                .ToList();

            foreach (var edge in edges)
            {
                var from = edge[0];
                var to = edge[1];
                var cost = edge[2];

                if (cost >= threshold &&
                    online[from] &&
                    online[to])
                {
                    graph[from].Add((to, cost));
                }
            }

            var shortestPath = Dijkstra(0, n - 1, graph);

            if (shortestPath <= k)
            {
                best = threshold;
                low = threshold + 1;
            }
            else
            {
                high = threshold - 1;
            }
        }

        return (int)best;
    }

    private static long Dijkstra(int source, int target, List<List<(int To, int Cost)>> graph)
    {
        const long infinity = long.MaxValue / 4;

        var distance = Enumerable.Repeat(infinity, graph.Count).ToArray();
        distance[source] = 0;

        var queue = new PriorityQueue<int, long>();
        queue.Enqueue(source, 0);

        while (queue.TryDequeue(out var node, out var currentDistance))
        {
            if (currentDistance > distance[node])
            {
                continue;
            }

            if (node == target)
            {
                return currentDistance;
            }

            foreach (var (next, cost) in graph[node])
            {
                var newDistance = currentDistance + cost;

                if (newDistance >= distance[next])
                {
                    continue;
                }

                distance[next] = newDistance;
                queue.Enqueue(next, newDistance);
            }
        }

        return infinity;
    }
}