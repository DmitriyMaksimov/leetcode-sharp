namespace leetcode_sharp;

// 101. Symmetric Tree
// https://leetcode.com/problems/symmetric-tree/
public class S00101
{
    public bool IsSymmetric(TreeNode? root)
    {
        return isSymmetric(root, root);
    }

    private static bool isSymmetric(TreeNode? n1, TreeNode? n2)
    {
        if (n1 == null && n2 == null)
        {
            return true;
        }
        
        return n1?.left?.val == n2?.right?.val && n2?.left?.val == n1?.right?.val && isSymmetric(n1?.left, n2?.right) && isSymmetric(n2?.left, n1?.right);
    }
}