namespace leetcode_sharp;

// 3203. Find Minimum Diameter After Merging Two Trees
// https://leetcode.com/problems/find-minimum-diameter-after-merging-two-trees
public class S03203
{
    public int MinimumDiameterAfterMerge(int[][] edges1, int[][] edges2)
    {
        var diameter1 = Bfs(edges1);
        var diameter2 = Bfs(edges2);

        var d1 = (int)Math.Ceiling(diameter1 / 2.0);
        var d2 = (int)Math.Ceiling(diameter2 / 2.0);

        return Math.Max(d1 + d2 + 1, Math.Max(diameter1, diameter2));
    }

    private static int Bfs(int[][] edges)
    {
        if (edges.Length == 0)
        {
            return 0;
        }

        var n = edges.Length + 1;
        var graph = new Dictionary<int, HashSet<int>>();

        foreach (var edge in edges)
        {
            var i = edge[0];
            var j = edge[1];

            graph.TryAdd(i, []);
            graph[i].Add(j);

            graph.TryAdd(j, []);
            graph[j].Add(i);
        }

        var leaves = new List<int>();

        for (var i = 0; i < n; i++)
        {
            if (graph.TryGetValue(i, out var value) && value.Count == 1)
            {
                leaves.Add(i);
            }
        }

        var remain = n;
        var step = 0;

        while (remain > 2)
        {
            remain -= leaves.Count;
            var newLeaves = new List<int>();

            foreach (var leaf in leaves)
            {
                var neighbor = graph[leaf].First();
                graph[leaf].Remove(neighbor);
                graph[neighbor].Remove(leaf);

                if (graph[neighbor].Count == 1)
                {
                    newLeaves.Add(neighbor);
                }
            }

            step++;
            leaves = newLeaves;
        }

        return remain == 2 ? step * 2 + 1 : step * 2;
    }
}
