namespace leetcode_sharp;

// 2685. Count the Number of Complete Components
// https://leetcode.com/problems/count-the-number-of-complete-components
public class S02685
{
    public int CountCompleteComponents(int n, int[][] edges)
    {
        List<List<int>> con = [];

        for (var i = 0; i < n; i++)
        {
            con.Add([]);
        }

        foreach (var edge in edges)
        {
            con[edge[0]].Add(edge[1]);
            con[edge[1]].Add(edge[0]);
        }

        var visited = new bool[n];
        var result = 0;

        for (var i = 0; i < n; ++i)
        {
            if (!visited[i])
            {
                var x = 0;
                var y = 0;
                Dfs(i, con, visited, ref x, ref y);
                result += x * (x - 1) == y ? 1 : 0;
            }
        }

        return result;
    }

    private static void Dfs(int x, List<List<int>> con, bool[] visited, ref int a, ref int b)
    {
        if (visited[x])
        {
            return;
        }

        visited[x] = true;
        ++a;
        b += con[x].Count;

        foreach (var y in con[x])
        {
            Dfs(y, con, visited, ref a, ref b);
        }
    }
}
