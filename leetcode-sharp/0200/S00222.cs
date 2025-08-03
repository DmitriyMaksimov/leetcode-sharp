namespace leetcode_sharp;

// 1929. Concatenation of Array
// https://leetcode.com/problems/count-complete-tree-nodes/
public class S00222
{
    public int CountNodes(TreeNode? root)
    {
        if (root is null) return 0;

        return CountNodes(root.left) + CountNodes(root.right) + 1;
    }
}