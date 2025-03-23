namespace leetcode_sharp;

// 1976. Number of Ways to Arrive at Destination
// https://leetcode.com/problems/number-of-ways-to-arrive-at-destination
public class S01976
{
    private const int Mod = 1_000_000_007;

    public int CountPaths(int n, int[][] roads)
    {
        var graph = new List<(int, int)>[n];

        for (var i = 0; i < n; i++)
        {
            graph[i] = [];
        }

        foreach (var road in roads)
        {
            graph[road[0]].Add((road[1], road[2]));
            graph[road[1]].Add((road[0], road[2]));
        }

        var distances = Enumerable.Repeat(long.MaxValue, n).ToArray();
        var path = new int[n];
        var priorityQueue = new PriorityQueue<(long, int), long>();
        priorityQueue.Enqueue((0, 0), 0);
        distances[0] = 0;
        path[0] = 1;

        while (priorityQueue.Count > 0)
        {
            var (distance, node) = priorityQueue.Dequeue();

            if (distance > distances[node])
            {
                continue;
            }

            foreach (var (neighbor, weight) in graph[node])
            {
                var newDist = distance + weight;

                if (newDist < distances[neighbor])
                {
                    distances[neighbor] = newDist;
                    priorityQueue.Enqueue((newDist, neighbor), newDist);
                    path[neighbor] = path[node] % Mod;
                }
                else if (newDist == distances[neighbor])
                {
                    path[neighbor] = (path[neighbor] + path[node]) % Mod;
                }
            }
        }

        return path[n - 1];
    }
}
