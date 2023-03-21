namespace leetcode_sharp;

// 886. Possible Bipartition
// https://leetcode.com/problems/possible-bipartition/
public class S00886
{
    public bool PossibleBipartition(int n, int[][] dislikes)
    {
        var graph = new int[n, n];
        foreach (var d in dislikes)
        {
            graph[d[0] - 1, d[1] - 1] = 1;
            graph[d[1] - 1, d[0] - 1] = 1;
        }

        var group = new int[n];
        for (var i = 0; i < n; i++)
        {
            if (group[i] == 0 && !dfs(graph, group, i, 1, n))
            {
                return false;
            }
        }

        return true;
    }

    private bool dfs(int[,] graph, int[] group, int index, int g, int n)
    {
        group[index] = g;
        for (var i = 0; i < n; i++)
        {
            if (graph[index, i] != 1) continue;
            
            if (group[i] == g)
            {
                return false;
            }

            if (group[i] == 0 && !dfs(graph, group, i, -g, n))
            {
                return false;
            }
        }

        return true;
    }
}