namespace leetcode_sharp;

// 951. Flip Equivalent Binary Trees
// https://leetcode.com/problems/flip-equivalent-binary-trees
public class S00951
{
    public bool FlipEquiv(TreeNode? root1, TreeNode? root2)
    {
        if (root1 == null || root2 == null)
        {
            return root1 == root2;
        }

        return root1.val == root2.val &&
               (FlipEquiv(root1.left, root2.left) && FlipEquiv(root1.right, root2.right) ||
                FlipEquiv(root1.left, root2.right) && FlipEquiv(root1.right, root2.left));
    }
}
