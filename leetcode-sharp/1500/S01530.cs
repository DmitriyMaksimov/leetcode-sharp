namespace leetcode_sharp;

// 1530. Number of Good Leaf Nodes Pairs
// https://leetcode.com/problems/number-of-good-leaf-nodes-pairs
public class S01530
{
    private int _result;

    public int CountPairs(TreeNode? root, int distance)
    {
        Dfs(root, distance);
        return _result;
    }

    private int[] Dfs(TreeNode? node, int distance)
    {
        var array = new int[distance + 1];

        if (node == null)
        {
            return array;
        }

        var left = Dfs(node.left, distance);
        var right = Dfs(node.right, distance);

        if (node.left == null && node.right == null)
        {
            array[1] = 1;
            return array;
        }

        for (var i = 0; i <= distance; ++i)
        {
            for (var j = 0; j <= distance; ++j)
            {
                if (i + j <= distance)
                {
                    _result += (left[i] * right[j]);
                }
            }
        }

        for (var i = 0; i < distance; ++i)
        {
            array[i + 1] += left[i] + right[i];
        }

        return array;
    }
}