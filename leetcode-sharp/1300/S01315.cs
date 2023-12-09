namespace leetcode_sharp;

// 1315. Sum of Nodes with Even-Valued Grandparent
// https://leetcode.com/problems/sum-of-nodes-with-even-valued-grandparent
public class S01315
{
    private int _result;

    public int SumEvenGrandparent(TreeNode? root)
    {
        dfs(root, null, null);
        return _result;
    }

    private void dfs(TreeNode? node, TreeNode? parent, TreeNode? grandp)
    {
        if (node == null) return;
        
        if (grandp != null && grandp.val % 2 == 0)
        {
            _result += node.val;
        }

        dfs(node.left, node, parent);
        dfs(node.right, node, parent);
    }
}