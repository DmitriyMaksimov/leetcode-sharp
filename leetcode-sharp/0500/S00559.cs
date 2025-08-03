namespace leetcode_sharp;

// 559. Maximum Depth of N-ary Tree
// https://leetcode.com/problems/maximum-depth-of-n-ary-tree/
public class S00559
{
    public class Node
    {
        public int val;
        public IList<Node>? children;

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

    private int _max;

    public int MaxDepth(Node? root)
    {
        Dfs(root, 0);
        return _max;
    }

    private void Dfs(Node? node, int d)
    {
        if (node == null)
        {
            return;
        }

        _max = Math.Max(_max, d + 1);

        foreach (var child in node.children ?? [])
        {
            Dfs(child, d + 1);
        }
    }
}