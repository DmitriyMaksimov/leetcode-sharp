namespace leetcode_sharp;

// 1382. Balance a Binary Search Tree
// https://leetcode.com/problems/balance-a-binary-search-tree
public class S01382
{
    private readonly List<int> _list = new();

    public TreeNode? BalanceBST(TreeNode? root)
    {
        inorder(root);
        return balance(_list, 0, _list.Count - 1);
    }

    private void inorder(TreeNode? root)
    {
        if (root == null)
        {
            return;
        }

        inorder(root.left);
        _list.Add(root.val);
        inorder(root.right);
    }

    private static TreeNode? balance(IReadOnlyList<int> list, int start, int end)
    {
        if (start > end)
        {
            return null;
        }

        var mid = (start + end) / 2;

        return new TreeNode
        {
            val = list[mid],
            left = balance(list, start, mid - 1),
            right = balance(list, mid + 1, end)
        };
    }
}