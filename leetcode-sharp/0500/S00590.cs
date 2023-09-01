namespace leetcode_sharp;

// 590. N-ary Tree Postorder Traversal
// https://leetcode.com/problems/n-ary-tree-postorder-traversal/
public class S00590
{
    public class Node
    {
        public int val;
        public IList<Node?>? children;

        public Node()
        {
        }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node?>? _children)
        {
            val = _val;
            children = _children;
        }
    }

    private readonly List<int> _result = new();

    public IList<int> Postorder(Node? root)
    {
        postorderTraversal(root);
        
        return _result;
    }

    private void postorderTraversal(Node? node)
    {
        if (node == null)
        {
            return;
        }

        foreach (var childNode in node.children ?? new List<Node?>())
        {
            postorderTraversal(childNode);
        }

        _result.Add(node.val);
    }
}