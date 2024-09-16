namespace leetcode_sharp;

// 2641. Cousins in Binary Tree II
// https://leetcode.com/problems/cousins-in-binary-tree-ii
public class S02641
{
    public TreeNode? ReplaceValueInTree(TreeNode? root)
    {
        root!.val = 0;

        Queue<TreeNode> queue = [];
        queue.Enqueue(root);

        while (queue.Count != 0)
        {
            var n = queue.Count;
            var sum = 0;

            List<TreeNode> buf = [];

            while (n-- > 0)
            {
                var node = queue.Dequeue();
                buf.Add(node);

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                    sum += node.left.val;
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                    sum += node.right.val;
                }
            }

            foreach (var node in buf)
            {
                var temp = sum;
                temp -= node.left?.val ?? 0;
                temp -= node.right?.val ?? 0;

                if (node.left != null)
                {
                    node.left.val = temp;
                }

                if (node.right != null)
                {
                    node.right.val = temp;
                }
            }
        }

        return root;
    }
}
