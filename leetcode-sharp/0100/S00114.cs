namespace leetcode_sharp;

// 114. Flatten Binary Tree to Linked List
// https://leetcode.com/problems/flatten-binary-tree-to-linked-list/
public class S00114
{
    private TreeNode prev;

    public void Flatten(TreeNode? root)
    {
        if (root == null)
        {
            return;
        }

        Flatten(root.right);
        Flatten(root.left);
        prev = root.right = prev;
        root.left = null;
        prev = root;
    }
}