namespace leetcode_sharp;

// 589. N-ary Tree Preorder Traversal
// https://leetcode.com/problems/n-ary-tree-preorder-traversal/
public class S00589
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

    private readonly List<int> _result = [];

    public IList<int> Preorder(Node? root)
    {
        preorderTraversal(root);
        
        return _result;
    }

    private void preorderTraversal(Node? node)
    {
        if (node == null)
        {
            return;
        }
        
        _result.Add(node.val);

        foreach (var childNode in node.children ?? new List<Node?>())
        {
            preorderTraversal(childNode);
        }
    }
}