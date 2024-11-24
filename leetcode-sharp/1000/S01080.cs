namespace leetcode_sharp;

// 1080. Insufficient Nodes in Root to Leaf Paths
// https://leetcode.com/problems/insufficient-nodes-in-root-to-leaf-paths
public class S01080
{
    public TreeNode? SufficientSubset(TreeNode? root, int limit)
    {
        if (root == null)
        {
            return root;
        }

        if (root.left == null && root.right == null)
        {
            return root.val < limit ? null : root;
        }

        root.left = SufficientSubset(root.left, limit - root.val);
        root.right = SufficientSubset(root.right, limit - root.val);

        return root.left == root.right ? null : root;
    }
}
