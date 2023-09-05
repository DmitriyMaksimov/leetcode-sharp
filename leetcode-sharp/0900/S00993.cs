namespace leetcode_sharp;

// 993. Cousins in Binary Tree
// https://leetcode.com/problems/cousins-in-binary-tree/
public class S00993
{
    public bool IsCousins(TreeNode? root, int x, int y)
    {
        var xParent = -1;
        var xDepth = -1;
        var yParent = -1;
        var yDepth = -1;
        
        var queue = new Queue<(TreeNode?, int, int)>();
        queue.Enqueue((root, 0, -1));

        while (queue.Count > 0)
        {
            var (node, depth, parent) = queue.Dequeue();
            if (node.val == x)
            {
                xParent = parent;
                xDepth = depth;
            }
            else if (node.val == y)
            {
                yParent = parent;
                yDepth = depth;
            }

            if (node.left != null)
            {
                queue.Enqueue((node.left, depth + 1, node.val));
            }

            if (node.right != null)
            {
                queue.Enqueue((node.right, depth + 1, node.val));
            }
        }

        return xParent != yParent && xDepth == yDepth;
    }
}