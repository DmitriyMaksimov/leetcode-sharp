namespace leetcode_sharp;

// 1008. Construct Binary Search Tree from Preorder Traversal
// https://leetcode.com/problems/construct-binary-search-tree-from-preorder-traversal
public class S01008
{
    public TreeNode BstFromPreorder(int[] preorder)
    {
        var len = preorder.Length;
        var root = new TreeNode(preorder[0]);
        var stack = new Stack<TreeNode>();

        stack.Push(root);

        for (var i = 1; i < len; ++i)
        {
            TreeNode? poppedNode = null;
            var node = new TreeNode(preorder[i]);

            while (stack.Count > 0 && stack.Peek().val < preorder[i])
            {
                poppedNode = stack.Pop();
            }

            if (poppedNode != null)
            {
                poppedNode.right = node;
            }
            else
            {
                stack.Peek().left = node;
            }

            stack.Push(node);
        }

        return root;
    }
}