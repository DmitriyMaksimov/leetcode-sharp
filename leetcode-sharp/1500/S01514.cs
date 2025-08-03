namespace leetcode_sharp;

// 1514. Path with Maximum Probability
// https://leetcode.com/problems/path-with-maximum-probability/
public class S01514
{
    public double MaxProbability(int n, int[][] edges, double[] succProb, int start, int end)
    {
        var graph = new Dictionary<int, List<int[]>>();
        for (var i = 0; i < edges.Length; i++)
        {
            var a = edges[i][0];
            var b = edges[i][1];

            graph[a] = graph.GetValueOrDefault(a, []);
            graph[a].Add([b, i]);
            
            graph[b] = graph.GetValueOrDefault(b, []);
            graph[b].Add([a, i]);
        }

        var probabilities = new double[n];
        probabilities[start] = 1.0;

        var queue = new Queue<int>();
        queue.Enqueue(start);

        while (queue.Any())
        {
            var current = queue.Dequeue();
            foreach (var neighbor in graph.GetValueOrDefault(current, []))
            {
                var next = neighbor[0];
                var i = neighbor[1];
                var newProb = probabilities[current] * succProb[i];

                if (newProb > probabilities[next])
                {
                    probabilities[next] = newProb;
                    queue.Enqueue(next);
                }
            }
        }

        return probabilities[end];
    }
}