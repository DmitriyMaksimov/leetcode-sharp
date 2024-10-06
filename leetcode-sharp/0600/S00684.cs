namespace leetcode_sharp;

// 684. Redundant Connection
// https://leetcode.com/problems/redundant-connection
public class S00684
{
    public int[] FindRedundantConnection(int[][] edges)
    {
        var parent = Enumerable.Range(0, 2001).ToArray();

        foreach (var edge in edges)
        {
            var from = edge[0];
            var to = edge[1];

            if (Find(parent, from) == Find(parent, to))
            {
                return edge;
            }

            parent[Find(parent, from)] = Find(parent, to);
        }

        return new int[2];
    }

    private static int Find(int[] parent, int f)
    {
        if (f != parent[f])
        {
            parent[f] = Find(parent, parent[f]);
        }

        return parent[f];
    }
}
