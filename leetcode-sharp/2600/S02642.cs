namespace leetcode_sharp;

// 2642. Design Graph With Shortest Path Calculator
// https://leetcode.com/problems/design-graph-with-shortest-path-calculator
public class S02642
{
    public class Graph
    {
        private readonly Queue<(int neighbour, int weight)>[] _queues;

        public Graph(int n, int[][] edges)
        {
            _queues = new Queue<(int, int)>[n];
            for (var i = 0; i < n; i++)
            {
                _queues[i] = new Queue<(int, int)>();
            }

            foreach (var e in edges)
            {
                AddEdge(e);
            }
        }

        public void AddEdge(int[] edge)
        {
            _queues[edge[0]].Enqueue((edge[1], edge[2]));
        }

        public int ShortestPath(int node1, int node2)
        {
            var visited = new bool[_queues.Length];
            var distances = new int[_queues.Length];
            Array.Fill(distances, int.MaxValue);

            var priorityQueue = new PriorityQueue<int, int>();

            distances[node1] = 0;
            priorityQueue.Enqueue(node1, 0);

            while (priorityQueue.Count > 0)
            {
                var nd = priorityQueue.Dequeue();
                visited[nd] = true;

                foreach (var (neighbour, weight) in _queues[nd])
                {
                    if (visited[neighbour])
                    {
                        continue;
                    }

                    var newDistance = distances[nd] + weight;
                    if (newDistance < distances[neighbour])
                    {
                        distances[neighbour] = newDistance;
                        priorityQueue.Enqueue(neighbour, newDistance);
                    }
                }
            }

            return distances[node2] == int.MaxValue ? -1 : distances[node2];
        }
    }
}