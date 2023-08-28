namespace leetcode_sharp;

// 257. Binary Tree Paths
// https://leetcode.com/problems/binary-tree-paths/
public class S00257
{
    public IList<string> BinaryTreePaths(TreeNode? root)
    {
        var result = new List<string>();
        if (root == null)
        {
            return result;
        }

        var path = new List<int> {root.val};
        if (root.left == null && root.right == null)
        {
            result.Add(string.Join("->", path));
            return result;
        }

        if (root.left != null)
        {
            dfs(root.left, path, result);
        }

        if (root.right != null)
        {
            dfs(root.right, path, result);
        }

        return result;
    }

    private static void dfs(TreeNode rootRight, IList<int> path, ICollection<string> result)
    {
        path.Add(rootRight.val);
        if (rootRight.left == null && rootRight.right == null)
        {
            result.Add(string.Join("->", path));
            path.RemoveAt(path.Count - 1);
            return;
        }

        if (rootRight.left != null)
        {
            dfs(rootRight.left, path, result);
        }

        if (rootRight.right != null)
        {
            dfs(rootRight.right, path, result);
        }

        path.RemoveAt(path.Count - 1);
    }
}