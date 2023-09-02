namespace leetcode_sharp;

// 606. Construct String from Binary Tree
// https://leetcode.com/problems/construct-string-from-binary-tree/
public class S00606
{
    public string Tree2str(TreeNode? root)
    {
        if (root == null)
        {
            return string.Empty;
        }

        var left = Tree2str(root.left);
        var right = Tree2str(root.right);
        if (string.IsNullOrEmpty(left) && string.IsNullOrEmpty(right))
        {
            return root.val.ToString();
        }

        return string.IsNullOrEmpty(right) ? $"{root.val}({left})" : $"{root.val}({left})({right})";
    }
}