namespace leetcode_sharp;

// 998. Maximum Binary Tree II
// https://leetcode.com/problems/maximum-binary-tree-ii
public class S00998
{
    public TreeNode? InsertIntoMaxTree(TreeNode? root, int val)
    {
        if (root == null || val > root.val)
        {
            return new TreeNode { val = val, left = root };
        }

        root.right = InsertIntoMaxTree(root.right, val);

        return root;
    }
}
