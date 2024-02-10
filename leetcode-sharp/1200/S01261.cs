namespace leetcode_sharp;

// 1261. Find Elements in a Contaminated Binary Tree
// https://leetcode.com/problems/find-elements-in-a-contaminated-binary-tree
public static class S01261
{
    public class FindElements
    {
        private readonly HashSet<int> _hashSet = [];

        public FindElements(TreeNode root)
        {
            dfs(root, 0);
        }

        private void dfs(TreeNode? node, int val)
        {
            if (node == null) return;

            _hashSet.Add(val);
            node.val = val;

            dfs(node.left, 2 * val + 1);
            dfs(node.right, 2 * val + 2);
        }

        public bool Find(int target)
        {
            return _hashSet.Contains(target);
        }
    }
}