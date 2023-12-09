namespace leetcode_sharp;

// 1038. Binary Search Tree to Greater Sum Tree
// https://leetcode.com/problems/binary-search-tree-to-greater-sum-tree
public class S01038
{
    public TreeNode? BstToGst(TreeNode? root)
    {
        var sum = 0;

        var stack = new Stack<TreeNode>();
        var current = root;

        while (stack.Any() || current != null)
        {
            while (current != null)
            {
                stack.Push(current);
                current = current.right;
            }

            current = stack.Pop();
            sum += current.val;
            current.val = sum;
            current = current.left;
        }

        return root;
    }
}