namespace leetcode_sharp;

// 2368. Reachable Nodes With Restrictions
// https://leetcode.com/problems/reachable-nodes-with-restrictions
public class S02368
{
    public int ReachableNodes(int n, int[][] edges, int[] restricted)
    {
        var adjacencyList = new List<List<int>>(n);

        for (var k = 0; k < n; k++)
        {
            adjacencyList.Add([]);
        }

        var restrictedSet = new HashSet<int>(restricted);

        foreach (var edge in edges)
        {
            if (!restrictedSet.Contains(edge[0]) && !restrictedSet.Contains(edge[1]))
            {
                adjacencyList[edge[0]].Add(edge[1]);
                adjacencyList[edge[1]].Add(edge[0]);
            }
        }

        return Dfs(0, -1, adjacencyList);
    }

    private static int Dfs(int i, int from, List<List<int>> adjacencyList)
    {
        return adjacencyList[i].Aggregate(1, (sum, j) =>
            sum + (j == from ? 0 : Dfs(j, i, adjacencyList))
        );
    }
}
