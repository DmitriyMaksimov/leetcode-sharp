namespace leetcode_sharp;

// 652. Find Duplicate Subtrees
// https://leetcode.com/problems/find-duplicate-subtrees/
public class S00652
{
    private readonly Dictionary<string, int> _map = new();
    private readonly List<TreeNode> _result = new();

    public IList<TreeNode> FindDuplicateSubtrees(TreeNode? root)
    {
        postOrderTraversal(root);
        return _result;
    }

    private string postOrderTraversal(TreeNode? root)
    {
        if (root == null)
            return "/";

        var left = postOrderTraversal(root.left);
        var right = postOrderTraversal(root.right);

        var curr = root.val + "/" + left + "/" + right;

        if (_map.GetValueOrDefault(curr) == 1) 
            _result.Add(root);

        _map[curr] = _map.GetValueOrDefault(curr) + 1; 

        return curr; 
    }
}