namespace leetcode_sharp;

// 3493. Properties Graph
// https://leetcode.com/problems/properties-graph
public class S03493
{
    public int NumberOfComponents(int[][] properties, int k)
    {
        var n = properties.Length;
        var count = n;
        var parent = Enumerable.Range(0, n).ToArray();
        var map = new Dictionary<int, HashSet<int>>();

        for (var i = 0; i < n; i++)
        {
            map.TryAdd(i, []);

            foreach (var val in properties[i])
            {
                map[i].Add(val);
            }
        }

        for (var i = 0; i < n; i++)
        {
            for (var j = i + 1; j < n; j++)
            {
                if (IsConnected(map, k, i, j))
                {
                    count -= Union(i, j, parent);
                }
            }
        }

        return count;
    }

    private static bool IsConnected(Dictionary<int, HashSet<int>> map, int k, int i, int j)
    {
        foreach (var _ in map[i].Where(t => map[j].Contains(t)))
        {
            k--;
        }

        return k <= 0;
    }

    private static int Find(int node, int[] parent)
    {
        if (parent[node] != node)
        {
            parent[node] = Find(parent[node], parent);
        }

        return parent[node];
    }

    private static int Union(int a, int b, int[] parent)
    {
        var rootA = Find(a, parent);
        var rootB = Find(b, parent);

        if (rootA != rootB)
        {
            parent[rootB] = rootA;
            return 1;
        }

        return 0;
    }
}