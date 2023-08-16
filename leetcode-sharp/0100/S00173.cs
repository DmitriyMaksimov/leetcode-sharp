namespace leetcode_sharp;

// 173. Binary Search Tree Iterator
// https://leetcode.com/problems/binary-search-tree-iterator/
public static class S00173
{
    public class BSTIterator
    {
        private readonly Stack<TreeNode> _stack = new();

        public BSTIterator(TreeNode? root)
        {
            populateStack(root);
        }

        public int Next()
        {
            var root = _stack.Pop();
            var val = root.val;

            root = root.right;
            populateStack(root);
            return val;
        }

        public bool HasNext()
        {
            return _stack.Count > 0;
        }

        private void populateStack(TreeNode? root)
        {
            while (root != null)
            {
                _stack.Push(root);
                root = root.left;
            }
        }
    }
}