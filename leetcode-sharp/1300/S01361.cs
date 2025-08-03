namespace leetcode_sharp;

// 1361. Validate Binary Tree Nodes
// https://leetcode.com/problems/validate-binary-tree-nodes
public class S01361
{
    public bool ValidateBinaryTreeNodes(int n, int[] leftChild, int[] rightChild)
    {
        var graph = new Dictionary<int, List<int>>();
        var inDegree = new int[n];

        for (var node = 0; node < n; node++)
        {
            var left = leftChild[node];
            var right = rightChild[node];
            if (left != -1)
            {
                if (!graph.ContainsKey(node))
                {
                    graph[node] = [];
                }

                graph[node].Add(left);
                inDegree[left]++;
            }

            if (right != -1)
            {
                if (!graph.ContainsKey(node))
                {
                    graph[node] = [];
                }

                graph[node].Add(right);
                inDegree[right]++;
            }
        }

        var rootCandidates = new List<int>();
        for (var node = 0; node < n; node++)
        {
            if (inDegree[node] == 0)
            {
                rootCandidates.Add(node);
            }
        }

        if (rootCandidates.Count != 1)
        {
            return false;
        }

        var root = rootCandidates[0];

        var queue = new Queue<int>();
        var seen = new HashSet<int>();
        queue.Enqueue(root);
        seen.Add(root);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (graph.TryGetValue(node, out var value))
            {
                foreach (var child in value)
                {
                    if (seen.Contains(child))
                    {
                        return false;
                    }

                    seen.Add(child);
                    queue.Enqueue(child);
                }
            }
        }

        return seen.Count == n;
    }
}