namespace leetcode_sharp;

// 721. Accounts Merge
// https://leetcode.com/problems/accounts-merge
public class S00721
{
    public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
    {
        var graph = new Dictionary<string, HashSet<string>>(); // <email node, neighbor nodes>
        var name = new Dictionary<string, string>(); // <email, username>

        foreach (var account in accounts)
        {
            var userName = account[0];
            for (var i = 1; i < account.Count; i++)
            {
                if (!graph.ContainsKey(account[i]))
                {
                    graph[account[i]] = [];
                }

                name[account[i]] = userName;

                if (i == 1) continue;
                graph[account[i]].Add(account[i - 1]);
                graph[account[i - 1]].Add(account[i]);
            }
        }

        var visited = new HashSet<string>();
        var res = new List<IList<string>>();

        foreach (var email in name.Keys)
        {
            if (!visited.Add(email))
            {
                continue;
            }

            var list = new List<string>();
            Dfs(graph, email, visited, list);
            list.Sort(StringComparer.Ordinal);
            list.Insert(0, name[email]);
            res.Add(list);
        }

        return res;
    }

    private static void Dfs(Dictionary<string, HashSet<string>> graph, string email, HashSet<string> visited, List<string> list)
    {
        list.Add(email);
        foreach (var next in graph[email])
        {
            if (!visited.Add(next))
            {
                continue;
            }

            Dfs(graph, next, visited, list);
        }
    }
}
