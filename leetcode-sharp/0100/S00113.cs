namespace leetcode_sharp;

// 113. Path Sum II
// https://leetcode.com/problems/path-sum-ii
public class S00113
{
    private readonly List<IList<int>> _result = [];

    public IList<IList<int>> PathSum(TreeNode? root, int targetSum)
    {
        var path = new List<int>();

        Dfs(root, targetSum, path);

        return _result;
    }

    private void Dfs(TreeNode? root, int targetSum, List<int> path)
    {
        if (root == null)
        {
            return;
        }

        path.Add(root.val);
        targetSum -= root.val;

        if (root.left == null && root.right == null)
        {
            if (targetSum == 0)
            {
                _result.Add(new List<int>(path));
            }
        }
        else
        {
            Dfs(root.left, targetSum, path);
            Dfs(root.right, targetSum, path);
        }

        path.RemoveAt(path.Count - 1);
    }
}
