namespace leetcode_sharp;

// 2192. All Ancestors of a Node in a Directed Acyclic Graph
// https://leetcode.com/problems/all-ancestors-of-a-node-in-a-directed-acyclic-graph
public class S02192
{
    public IList<IList<int>> GetAncestors(int n, int[][] edges)
    {
        var ans = new List<IList<int>>();
        var directChild = new List<List<int>>();

        for (var i = 0; i < n; i++)
        {
            ans.Add([]);
            directChild.Add([]);
        }

        foreach (var edge in edges)
        {
            directChild[edge[0]].Add(edge[1]);
        }

        for (var i = 0; i < n; i++)
        {
            Dfs(i, i, ans, directChild);
        }

        return ans;
    }

    private static void Dfs(int x, int curr, List<IList<int>> ans, List<List<int>> directChild)
    {
        foreach (var ch in directChild[curr])
        {
            var currentAnswer = ans[ch];

            if (currentAnswer.Count == 0 || currentAnswer[^1] != x)
            {
                currentAnswer.Add(x);
                Dfs(x, ch, ans, directChild);
            }
        }
    }
}