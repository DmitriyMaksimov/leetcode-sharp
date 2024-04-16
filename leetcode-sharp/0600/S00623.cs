namespace leetcode_sharp;

// 623. Add One Row to Tree
// https://leetcode.com/problems/add-one-row-to-tree
public class S00623
{
    public TreeNode? AddOneRow(TreeNode? root, int val, int depth)
    {
        if (depth is 0 or 1)
        {
            return new TreeNode(val)
            {
                left = depth == 1 ? root : null,
                right = depth == 0 ? root : null
            };
        }

        if (root != null && depth >= 2)
        {
            root.left = AddOneRow(root.left, val, depth > 2 ? depth - 1 : 1);
            root.right = AddOneRow(root.right, val, depth > 2 ? depth - 1 : 0);
        }

        return root;
    }
}