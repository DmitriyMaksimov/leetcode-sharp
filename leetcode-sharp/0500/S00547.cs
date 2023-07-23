namespace leetcode_sharp;

// 547. Number of Provinces
// https://leetcode.com/problems/number-of-provinces/
public class S00547
{
    public int FindCircleNum(int[][] isConnected)
    {
        var n = isConnected.Length;
        var provinces = 0;
        var visited = new bool[n];

        for (var i = 0; i < n; i++)
        {
            if (visited[i]) continue;
            
            provinces++;
            dfs(isConnected, visited, i);
        }

        return provinces;
    }

    private static void dfs(IReadOnlyList<int[]> isConnected, IList<bool> visited, int node)
    {
        visited[node] = true;

        for (var neighbor = 0; neighbor < isConnected.Count; neighbor++)
        {
            if (isConnected[node][neighbor] == 1 && !visited[neighbor])
            {
                dfs(isConnected, visited, neighbor);
            }
        }
    }
}