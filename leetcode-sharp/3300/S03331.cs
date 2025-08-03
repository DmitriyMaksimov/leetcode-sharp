namespace leetcode_sharp;

// 3331. Find Subtree Sizes After Changes
// https://leetcode.com/problems/find-subtree-sizes-after-changes
public class S03331
{
    public int[] FindSubtreeSizes(int[] parent, string s)
    {
        var n = parent.Length;
        var adj = new List<List<int>>(n);

        for (var i = 0; i < n; i++)
        {
            adj.Add([]);
        }

        for (var i = 1; i < n; i++)
        {
            adj[parent[i]].Add(i);
        }

        var newParent = new int[n];
        Array.Copy(parent, newParent, n);
        var lastSeen = new Dictionary<char, int>();
        DfsAdjustParent(0, s, adj, lastSeen, newParent);

        var finalAdj = new List<List<int>>(n);
        for (var i = 0; i < n; i++)
        {
            finalAdj.Add([]);
        }

        for (var i = 1; i < n; i++)
        {
            finalAdj[newParent[i]].Add(i);
        }

        var answer = new int[n];
        DfsCountSubtreeSizes(0, finalAdj, answer);

        return answer;
    }

    private static void DfsAdjustParent(int node, string s, List<List<int>> adj, Dictionary<char, int> lastSeen, int[] newParent)
    {
        var c = s[node];
        if (lastSeen.TryGetValue(c, out var prev) && prev != newParent[node])
        {
            newParent[node] = prev;
        }

        var originalParent = lastSeen.ContainsKey(c) ? lastSeen[c] : -1;
        lastSeen[c] = node;

        foreach (var child in adj[node])
        {
            DfsAdjustParent(child, s, adj, lastSeen, newParent);
        }

        if (originalParent == -1)
        {
            lastSeen.Remove(c);
        }
        else
        {
            lastSeen[c] = originalParent;
        }
    }

    private static int DfsCountSubtreeSizes(int node, List<List<int>> adj, int[] answer)
    {
        var size = 1 + adj[node].Sum(child => DfsCountSubtreeSizes(child, adj, answer));

        return answer[node] = size;
    }
}
