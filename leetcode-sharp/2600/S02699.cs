namespace leetcode_sharp;

// 2699. Modify Graph Edge Weights
// https://leetcode.com/problems/modify-graph-edge-weights
public class S02699
{
    public int[][] ModifiedGraphEdges(int n, int[][] edges, int source, int destination, int target)
    {
        var adjacencyList = new List<(int, int)>[n];
        for (var i = 0; i < n; i++)
        {
            adjacencyList[i] = [];
        }

        for (var i = 0; i < edges.Length; i++)
        {
            var nodeA = edges[i][0];
            var nodeB = edges[i][1];

            adjacencyList[nodeA].Add((nodeB, i));
            adjacencyList[nodeB].Add((nodeA, i));
        }

        var distances = new int[n, 2];

        for (var i = 0; i < n; i++)
        {
            distances[i, 0] = distances[i, 1] = i == source ? 0 : int.MaxValue;
        }

        Dijkstra(adjacencyList, edges, distances, source, 0, 0);
        var difference = target - distances[destination, 0];
        if (difference < 0) return [];

        Dijkstra(adjacencyList, edges, distances, source, difference, 1);
        if (distances[destination, 1] < target) return [];

        foreach (var edge in edges)
        {
            if (edge[2] == -1) edge[2] = 1;
        }

        return edges;
    }

    private void Dijkstra(List<(int, int)>[] adjacencyList, int[][] edges, int[,] distances, int source, int difference, int run)
    {
        var priorityQueue = new SortedSet<(int, int)>(Comparer<(int, int)>.Create((a, b) => a.Item2 != b.Item2 ? a.Item2.CompareTo(b.Item2) : a.Item1.CompareTo(b.Item1))) { (source, 0) };
        distances[source, run] = 0;

        while (priorityQueue.Count > 0)
        {
            var (currentNode, currentDistance) = priorityQueue.Min;
            priorityQueue.Remove((currentNode, currentDistance));

            if (currentDistance > distances[currentNode, run]) continue;

            foreach (var (nextNode, edgeIndex) in adjacencyList[currentNode])
            {
                var weight = edges[edgeIndex][2];
                if (weight == -1) weight = 1;

                if (run == 1 && edges[edgeIndex][2] == -1)
                {
                    var newWeight = difference + distances[nextNode, 0] - distances[currentNode, 1];
                    if (newWeight > weight)
                    {
                        edges[edgeIndex][2] = weight = newWeight;
                    }
                }

                if (distances[nextNode, run] > distances[currentNode, run] + weight)
                {
                    priorityQueue.Remove((nextNode, distances[nextNode, run]));
                    distances[nextNode, run] = distances[currentNode, run] + weight;
                    priorityQueue.Add((nextNode, distances[nextNode, run]));
                }
            }
        }
    }
}
