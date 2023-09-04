namespace leetcode_sharp;

// 897. Increasing Order Search Tree
// https://leetcode.com/problems/increasing-order-search-tree/
public class S00897
{
    public TreeNode IncreasingBST(TreeNode? root)
    {
        var list = new List<int>();

        traverse(root, list);
        var result = new TreeNode(list[0]);
        var current = result;

        for (var i = 1; i < list.Count; i++)
        {
            current.right = new TreeNode(list[i]);
            current = current.right;
        }

        return result;
    }

    private static void traverse(TreeNode? node, ICollection<int> list)
    {
        if (node == null) return;
        traverse(node.left, list);
        list.Add(node.val);
        traverse(node.right, list);
    }
}