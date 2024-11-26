namespace leetcode_sharp;

// 3067. Count Pairs of Connectable Servers in a Weighted Tree Network
// https://leetcode.com/problems/count-pairs-of-connectable-servers-in-a-weighted-tree-network
public class S03067
{
    public int[] CountPairsOfConnectableServers(int[][] edges, int signalSpeed)
    {
        var n = edges.Length + 1;
        var adjacent = new List<List<(int node, int weight)>>();

        for (var i = 0; i < n; i++)
        {
            adjacent.Add([]);
        }

        foreach (var edge in edges)
        {
            adjacent[edge[0]].Add((edge[1], edge[2]));
            adjacent[edge[1]].Add((edge[0], edge[2]));
        }

        return Enumerable.Range(0, n).Select(i => Dfs(i, i, 0, signalSpeed, adjacent)).ToArray();
    }

    private static int Dfs(int i, int parent, int dist, int signalSpeed, List<List<(int node, int weight)>> adjacent)
    {
        var count = dist > 0 && dist % signalSpeed == 0 ? 1 : 0;
        var pairs = 0;

        foreach (var (j, w) in adjacent[i])
        {
            if (j != parent)
            {
                var countJ = Dfs(j, i, dist + w, signalSpeed, adjacent);
                pairs += count * countJ;
                count += countJ;
            }
        }

        return i == parent ? pairs : count;
    }
}
