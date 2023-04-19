namespace leetcode_sharp;

// 1372. Longest ZigZag Path in a Binary Tree
// https://leetcode.com/problems/longest-zigzag-path-in-a-binary-tree/
public class S01372
{
    private enum Direction
    {
        Left,
        Right
    }

    private int _result;

    public int LongestZigZag(TreeNode? root)
    {
        maxZigZag(root, Direction.Left, 0);
        maxZigZag(root, Direction.Right, 0);

        return _result;
    }

    private void maxZigZag(TreeNode? node, Direction direction, int currentStep)
    {
        if (node == null)
        {
            return;
        }

        _result = Math.Max(_result, currentStep);

        if (direction == Direction.Left)
        {
            // We can continue current path
            maxZigZag(node.left, Direction.Right, currentStep + 1);
            // ...or start over
            maxZigZag(node.right, Direction.Left, 1);
        }
        else
        {
            maxZigZag(node.right, Direction.Left, currentStep + 1);
            maxZigZag(node.left, Direction.Right, 1);
        }
    }
}