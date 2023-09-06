namespace leetcode_sharp;

// 1022. Sum of Root To Leaf Binary Numbers
// https://leetcode.com/problems/sum-of-root-to-leaf-binary-numbers/
public class S01022
{
    public int SumRootToLeaf(TreeNode? root)
    {
        return sumRootToLeaf(root, 0);
    }
    
    private static int sumRootToLeaf(TreeNode? root, int sum)
    {
        if (root == null)
        {
            return 0;
        }
        
        sum = sum * 2 + root.val;
 
        if (root.left == null && root.right == null)
        {
            return sum;
        }
        
        return sumRootToLeaf(root.left, sum) + sumRootToLeaf(root.right, sum);
    }
}