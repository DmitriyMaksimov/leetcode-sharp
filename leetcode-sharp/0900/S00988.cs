namespace leetcode_sharp;

// 988. Smallest String Starting From Leaf
// https://leetcode.com/problems/smallest-string-starting-from-leaf
public class S00988
{
    public string SmallestFromLeaf(TreeNode? root)
    {
        return Dfs(root, "");
    }

    private static string Dfs(TreeNode? root, string s)
    {
        if (root == null)
        {
            return s;
        }

        s = (char)('a' + root.val) + s;

        if (root.left == null && root.right == null)
        {
            return s;
        }

        if (root.left == null)
        {
            return Dfs(root.right, s);
        }

        if (root.right == null)
        {
            return Dfs(root.left, s);
        }

        var left = Dfs(root.left, s);
        var right = Dfs(root.right, s);

        return left.CompareTo(right) <= 0 ? left : right;
    }
}