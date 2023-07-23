namespace leetcode_sharp;

// 1379. Find a Corresponding Node of a Binary Tree in a Clone of That Tree
// https://leetcode.com/problems/find-a-corresponding-node-of-a-binary-tree-in-a-clone-of-that-tree/
public class S01379
{
    private TreeNode? _result;

    public TreeNode? GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
    {
        dfs(cloned, target.val);
        return _result;
    }

    private void dfs(TreeNode? root, int val)
    {
        if (root == null)
        {
            return;
        }

        if (root.val == val)
        {
            _result = root;
            return;
        }

        dfs(root.left, val);
        dfs(root.right, val);
    }
}