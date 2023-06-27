namespace leetcode_sharp;

// 559. Maximum Depth of N-ary Tree
// https://leetcode.com/problems/maximum-depth-of-n-ary-tree/
public class S00559
{
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node()
        {
        }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }

    private int max;

    public int MaxDepth(Node? root)
    {
        dfs(root, 0);
        return max;
    }

    private void dfs(Node? node, int d)
    {
        if (node == null)
        {
            return;
        }

        max = Math.Max(max, d + 1);

        foreach (var child in node.children)
        {
            dfs(child, d + 1);
        }
    }
}