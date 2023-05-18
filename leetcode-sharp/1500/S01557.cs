namespace leetcode_sharp;

// 1557. Minimum Number of Vertices to Reach All Nodes
// https://leetcode.com/problems/minimum-number-of-vertices-to-reach-all-nodes/
public class S01557
{
    public IList<int> FindSmallestSetOfVertices(int n, IList<IList<int>> edges)
    {
        var res = new List<int>();
        var hasIncomingEdge = new bool[n];

        foreach (var edge in edges)
        {
            hasIncomingEdge[edge[1]] = true;
        }

        for (var i = 0; i < n; ++i)
        {
            if (!hasIncomingEdge[i])
            {
                res.Add(i);
            }
        }

        return res;
    }
}