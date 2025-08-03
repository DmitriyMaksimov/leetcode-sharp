namespace leetcode_sharp;

// 501. Find Mode in Binary Search Tree
// https://leetcode.com/problems/find-mode-in-binary-search-tree/
public class S00501
{
    public int[] FindMode(TreeNode? root)
    {
        var dict = new Dictionary<int, int>();
        var queue = new Queue<TreeNode?>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            dict[node!.val] = dict.GetValueOrDefault(node.val) + 1;

            if (node.left != null)
            {
                queue.Enqueue(node.left);
            }

            if (node.right != null)
            {
                queue.Enqueue(node.right);
            }
        }

        var max = dict.Values.Max();
        return dict.Where(x => x.Value == max).Select(x => x.Key).ToArray();
    }
}