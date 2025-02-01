namespace leetcode_sharp;

public static class TreeNodeExtensions
{
    public static string AsString(this TreeNode? root)
    {
        if (root == null) return "[]";

        var result = new List<string>();
        var queue = new Queue<TreeNode?>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (node == null)
            {
                result.Add("null");
                continue;
            }

            result.Add(node.val.ToString());
            queue.Enqueue(node.left);
            queue.Enqueue(node.right);
        }

        // Trim trailing "null" values
        var i = result.Count - 1;
        while (i >= 0 && result[i] == "null")
        {
            i--;
        }

        result = result.GetRange(0, i + 1);

        return "[" + string.Join(",", result) + "]";
    }
}
