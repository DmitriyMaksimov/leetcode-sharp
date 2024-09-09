namespace leetcode_sharp;

// 538. Convert BST to Greater Tree
// https://leetcode.com/problems/convert-bst-to-greater-tree
public class S00538
{
    private int _sum;

    public TreeNode? ConvertBST(TreeNode? root)
    {
        ConvertNode(root);
        return root;
    }

    private void ConvertNode(TreeNode? cur)
    {
        if (cur == null)
        {
            return;
        }

        ConvertNode(cur.right);

        cur.val += _sum;
        _sum = cur.val;

        ConvertNode(cur.left);
    }
}
