namespace leetcode_sharp;

// 515. Find Largest Value in Each Tree Row
// https://leetcode.com/problems/find-largest-value-in-each-tree-row
public class S00515
{
    public IList<int> LargestValues(TreeNode? root)
    {
        if (root == null) return new List<int>();

        var result = new List<int>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var currLevelSize = queue.Count;
            var maxVal = int.MinValue;

            for (var i = 0; i < currLevelSize; i++)
            {
                var node = queue.Dequeue();
                maxVal = Math.Max(maxVal, node.val);

                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }

            result.Add(maxVal);
        }

        return result;
    }
}