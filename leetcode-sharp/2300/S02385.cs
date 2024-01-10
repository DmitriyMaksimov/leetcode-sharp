namespace leetcode_sharp;

// 2385. Amount of Time for Binary Tree to Be Infected
// https://leetcode.com/problems/amount-of-time-for-binary-tree-to-be-infected
public class S02385
{
    private TreeNode? _startNode;

    public int AmountOfTime(TreeNode? root, int start)
    {
        var parents = new Dictionary<int, TreeNode?>();

        populateParents(root, null, start, parents);

        var queue = new Queue<TreeNode?>();
        queue.Enqueue(_startNode);
        
        var amountOfTime = -1;
        var visited = new HashSet<int>();

        while (queue.Count > 0)
        {
            var count = queue.Count;
            for (var i = 0; i < count; i++)
            {
                var temp = queue.Dequeue();
                visited.Add(temp!.val);

                if (temp.left != null && !visited.Contains(temp.left.val))
                {
                    queue.Enqueue(temp.left);
                }

                if (temp.right != null && !visited.Contains(temp.right.val))
                {
                    queue.Enqueue(temp.right);
                }

                if (parents[temp.val] != null && !visited.Contains(parents[temp.val]!.val))
                {
                    queue.Enqueue(parents[temp.val]);
                }
            }

            amountOfTime++;
        }

        return amountOfTime;
    }

    private void populateParents(TreeNode? root, TreeNode? prev, int start, Dictionary<int, TreeNode?> parent)
    {
        if (root == null)
        {
            return;
        }

        if (root.val == start)
        {
            _startNode = root;
        }

        parent[root.val] = prev;
        populateParents(root.left, root, start, parent);
        populateParents(root.right, root, start, parent);
    }
}