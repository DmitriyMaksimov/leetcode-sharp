namespace leetcode_sharp;

// 129. Sum Root to Leaf Numbers
// https://leetcode.com/problems/sum-root-to-leaf-numbers/
public class S00129
{
    private int _result = 0;
    
    public int SumNumbers(TreeNode? root)
    {
        preorderTraversal(root, 0);

        return _result;
    }
    
    private void preorderTraversal(TreeNode? node, int currentSum)
    {
        if (node == null)
        {
            return;
        }

        if (node.left == null && node.right == null)
        {
            // Leaf node => add sum to result
            _result += currentSum * 10 + node.val;
        }
        else
        {
            preorderTraversal(node.left, currentSum * 10 + node.val);
            preorderTraversal(node.right, currentSum * 10 + node.val);
        }
    }
}