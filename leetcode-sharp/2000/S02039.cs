namespace leetcode_sharp;

// 2039. The Time When the Network Becomes Idle
// https://leetcode.com/problems/the-time-when-the-network-becomes-idle
public class S02039
{
    public int NetworkBecomesIdle(int[][] edges, int[] patience)
    {
        var n = patience.Length;
        var adj = Enumerable.Repeat(0, n).Select(_ =>new List<int>() ).ToList();

        foreach (var edge in edges)
        {
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }

        var queue = new Queue<int>();
        queue.Enqueue(0);

        var visited = Enumerable.Repeat(-1, n).ToArray();
        visited[0] = 0;

        var level = 0;

        while (queue.Count > 0)
        {
            level++;
            var size = queue.Count;
            while (size-- > 0)
            {
                var node = queue.Dequeue();
                foreach (int next in adj[node].Where(next => visited[next] == -1))
                {
                    queue.Enqueue(next);
                    visited[next] = 2 * level;
                }
            }
        }

        var result = 0;

        for (var i = 1; i < visited.Length; i++)
        {
            var dist = visited[i];
            var val = dist * 2 - (dist % patience[i]);

            if (dist % patience[i] == 0)
            {
                val -= patience[i];
            }

            result = Math.Max(result, val);
        }

        return result + 1;
    }
}
