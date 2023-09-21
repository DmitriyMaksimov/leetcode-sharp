namespace leetcode_sharp;

// 2331. Evaluate Boolean Binary Tree
// https://leetcode.com/problems/evaluate-boolean-binary-tree/
public class S02331
{
    public bool EvaluateTree(TreeNode root)
    {
        return root.val switch
        {
            1 => true,
            0 => false,
            2 => EvaluateTree(root.left!) || EvaluateTree(root.right!),
            _ => EvaluateTree(root.left!) && EvaluateTree(root.right!)
        };
    }
}