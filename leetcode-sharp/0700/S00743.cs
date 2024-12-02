namespace leetcode_sharp;

// 743. Network Delay Time
// https://leetcode.com/problems/network-delay-time
public class S00743
{
    public int NetworkDelayTime(int[][] times, int n, int k)
    {
        var graph = new Dictionary<int, List<int[]>>();

        foreach (var edge in times)
        {
            graph.TryAdd(edge[0], []);
            graph[edge[0]].Add([edge[1], edge[2]]);
        }

        var pq = new PriorityQueue<int[], int>();
        pq.Enqueue([0, k], 0);

        var visited = new bool[n + 1];

        var minDis = Enumerable.Repeat(int.MaxValue, n + 1).ToArray();
        minDis[k] = 0;

        var max = 0;

        while (pq.Count > 0)
        {
            var curr = pq.Dequeue();
            var currDis = curr[0];
            var currNode = curr[1];
            if (visited[currNode])
            {
                continue;
            }

            visited[currNode] = true;
            max = currDis;
            n--;

            if (!graph.TryGetValue(currNode, out var value))
            {
                continue;
            }

            foreach (var next in value)
            {
                if (!visited[next[0]] && currDis + next[1] < minDis[next[0]])
                {
                    minDis[next[0]] = currDis + next[1];
                    pq.Enqueue([currDis + next[1], next[0]], currDis + next[1]);
                }
            }
        }

        return n == 0 ? max : -1;
    }
}
