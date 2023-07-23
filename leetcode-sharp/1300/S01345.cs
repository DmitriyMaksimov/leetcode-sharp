namespace leetcode_sharp;

// 1345. Jump Game IV
// https://leetcode.com/problems/jump-game-iv/
public class S01345
{
    public int MinJumps(int[] arr)
    {
        var n = arr.Length;
        if (n == 1)
        {
            return 0;
        }

        var graph = buildGraph(arr);

        var queue = new Queue<int>();
        var visited = new bool[n];
        queue.Enqueue(0);
        visited[0] = true;
        var steps = 0;

        while (queue.Any())
        {
            var size = queue.Count;
            while (size-- > 0)
            {
                var currIndex = queue.Dequeue();
                if (currIndex == n - 1)
                {
                    // Found solution
                    return steps;
                }

                var jumpNextIndices = graph[arr[currIndex]];
                jumpNextIndices.Add(currIndex - 1);
                jumpNextIndices.Add(currIndex + 1);

                foreach (var nextIndex in jumpNextIndices.Where(nextIndex => nextIndex >= 0 && nextIndex < n && !visited[nextIndex]))
                {
                    queue.Enqueue(nextIndex);
                    visited[nextIndex] = true;
                }

                jumpNextIndices.Clear();
            }

            steps++;
        }

        return -1;
    }

    private static Dictionary<int, List<int>> buildGraph(IReadOnlyList<int> arr)
    {
        var graph = new Dictionary<int, List<int>>();
        for (var i = 0; i < arr.Count; i++)
        {
            var element = arr[i];
            graph[element] = graph.GetValueOrDefault(element, new List<int>());
            graph[element].Add(i);
        }

        return graph;
    }
}