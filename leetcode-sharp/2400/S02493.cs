namespace leetcode_sharp;

// 2493. Divide Nodes Into the Maximum Number of Groups
// https://leetcode.com/problems/divide-nodes-into-the-maximum-number-of-groups
public class S02493
{
    public int MagnificentSets(int n, int[][] edges)
    {
        var graph = new Dictionary<int, List<int>>();
        for (var i = 1; i <= n; i++)
        {
            graph[i] = [];
        }

        foreach (var edge in edges)
        {
            var a = edge[0];
            var b = edge[1];
            graph[a].Add(b);
            graph[b].Add(a);
        }

        var components = new List<HashSet<int>>();
        var seen = new HashSet<int>();

        for (var i = 1; i <= n; i++)
        {
            if (seen.Contains(i))
            {
                continue;
            }

            var queue = new Queue<int>();
            queue.Enqueue(i);
            var visited = new HashSet<int> { i };

            while (queue.Count > 0)
            {
                var size = queue.Count;
                for (var j = 0; j < size; j++)
                {
                    var node = queue.Dequeue();
                    foreach (int neighbor in graph[node].Where(neighbor => !visited.Contains(neighbor)))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }

            components.Add(visited);
            seen.UnionWith(visited);
        }

        var longest = Enumerable.Repeat(-1, components.Count).ToArray();

        for (var k = 0; k < components.Count; k++)
        {
            foreach (var i in components[k])
            {
                longest[k] = Math.Max(longest[k], Bfs(graph, i));
            }
        }

        if (Array.Exists(longest, x => x < 0))
        {
            return -1;
        }

        return longest.Sum();
    }

    private static int Bfs(Dictionary<int, List<int>> graph, int start)
    {
        var queue = new Queue<int>();
        queue.Enqueue(start);
        var seen = new HashSet<int> { start };
        var seenLevel = new HashSet<int>();
        var result = 0;

        while (queue.Count > 0)
        {
            ++result;
            var nextLevel = new HashSet<int>();

            var size = queue.Count;
            for (var i = 0; i < size; i++)
            {
                var node = queue.Dequeue();
                foreach (var neighbor in graph[node])
                {
                    if (seenLevel.Contains(neighbor))
                    {
                        return -1;
                    }

                    if (!seen.Add(neighbor))
                    {
                        continue;
                    }

                    nextLevel.Add(neighbor);
                    queue.Enqueue(neighbor);
                }
            }

            seenLevel = nextLevel;
        }

        return result;
    }
}
