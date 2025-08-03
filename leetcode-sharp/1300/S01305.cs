namespace leetcode_sharp;

// 1305. All Elements in Two Binary Search Trees
// https://leetcode.com/problems/all-elements-in-two-binary-search-trees
public class S01305
{
    private readonly List<int> _result = [];

    private void dfs(TreeNode? root)
    {
        if (root == null)
            return;

        _result.Add(root.val);
        
        dfs(root.left);
        dfs(root.right);
    }

    public IList<int> GetAllElements(TreeNode? root1, TreeNode? root2)
    {
        dfs(root1);
        dfs(root2);

        _result.Sort();
        
        return _result;
    }
}