namespace leetcode_sharp;

// 1325. Delete Leaves With a Given Value
// https://leetcode.com/problems/delete-leaves-with-a-given-value
public class S01325
{
    public TreeNode? RemoveLeafNodes(TreeNode? root, int target)
    {
        if (root?.left != null)
        {
            root.left = RemoveLeafNodes(root.left, target);
        }

        if (root?.right != null)
        {
            root.right = RemoveLeafNodes(root.right, target);
        }

        return root?.left == root?.right && root?.val == target ? null : root;
    }
}