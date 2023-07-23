namespace leetcode_sharp;

// 1579. Remove Max Number of Edges to Keep Graph Fully Traversable
// https://leetcode.com/problems/remove-max-number-of-edges-to-keep-graph-fully-traversable/
public class S01579
{
    public int MaxNumEdgesToRemove(int n, int[][] edges)
    {
        Array.Sort(edges, (a, b) => b[0] - a[0]);

        var edgeAdd = 0;

        var alice = new UnionFind(n);
        var bob = new UnionFind(n);

        foreach (var edge in edges)
        {
            var type = edge[0];
            var a = edge[1];
            var b = edge[2];

            switch (type)
            {
                case 3:
                    if (alice.Unite(a, b) | bob.Unite(a, b))
                    {
                        edgeAdd++;
                    }

                    break;
                case 2:
                    if (bob.Unite(a, b))
                    {
                        edgeAdd++;
                    }

                    break;
                case 1:
                    if (alice.Unite(a, b))
                    {
                        edgeAdd++;
                    }

                    break;
            }
        }

        return alice.United() && bob.United() ? edges.Length - edgeAdd : -1;
    }
}