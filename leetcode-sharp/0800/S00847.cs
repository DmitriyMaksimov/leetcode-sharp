namespace leetcode_sharp;

// 847. Shortest Path Visiting All Nodes
// https://leetcode.com/problems/shortest-path-visiting-all-nodes/
public class S00847
{
    public int ShortestPathLength(int[][] graph)
    {
        var n = graph.Length;
        var all = (1 << n) - 1;
        var visited = new HashSet<(int, int)>();
        var queue = new Queue<(int node, int mask, int cost)>();

        for (var i = 0; i < n; i++)
        {
            var maskValue = 1 << i;
            var thisNode = (i, maskValue, 1);
            queue.Enqueue(thisNode);
            visited.Add((i, maskValue));
        }

        while (queue.Any())
        {
            var curr = queue.Dequeue();

            if (curr.mask == all)
            {
                return curr.cost - 1;
            }

            foreach (var adj in graph[curr.node])
            {
                var bothVisitedMask = curr.mask | (1 << adj);

                if (visited.Contains((adj, bothVisitedMask))) continue;

                visited.Add((adj, bothVisitedMask));
                queue.Enqueue((adj, bothVisitedMask, curr.cost + 1));
            }
        }

        return -1;
    }
}