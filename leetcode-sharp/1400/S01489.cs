namespace leetcode_sharp;

// 1489. Find Critical and Pseudo-Critical Edges in Minimum Spanning Tree
// https://leetcode.com/problems/find-critical-and-pseudo-critical-edges-in-minimum-spanning-tree/
public class S01489
{
    public IList<IList<int>> FindCriticalAndPseudoCriticalEdges(int n, int[][] edges)
    {
        var critical = new List<int>();
        var pseudo = new List<int>();

        var map = new Dictionary<int[], int>();
        for (var i = 0; i < edges.Length; i++)
        {
            map.Add(edges[i], i);
        }

        Array.Sort(edges, (a, b) => a[2] - b[2]);

        var minCost = BuildMst(n, edges, null, null);

        foreach (var edge in edges)
        {
            var index = map[edge];
            var costWithout = BuildMst(n, edges, null, edge);
            if (costWithout > minCost)
            {
                critical.Add(index);
            }
            else
            {
                var costWith = BuildMst(n, edges, edge, null);
                if (costWith == minCost)
                {
                    pseudo.Add(index);
                }
            }
        }

        return new List<IList<int>> {critical, pseudo};
    }

    private static int BuildMst(int n, int[][] edges, int[]? pick, int[]? skip)
    {
        var unionFind = new UnionFind(n);
        var cost = 0;

        if (pick != null)
        {
            unionFind.Unite(pick[0], pick[1]);
            cost += pick[2];
        }

        cost += edges.Where(edge => edge != skip && unionFind.Unite(edge[0], edge[1])).Sum(edge => edge[2]);

        return unionFind.United() ? cost : int.MaxValue;
    }
}