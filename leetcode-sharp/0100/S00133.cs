namespace leetcode_sharp;

// 133. Clone Graph
// https://leetcode.com/problems/clone-graph/
public class S00133
{
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }

    private readonly HashSet<int> _visited = new();
    private readonly Dictionary<int, Node> _nodes = new();

    public Node? CloneGraph(Node? node)
    {
        if (node == null)
        {
            return null;
        }

        createNodes(node);
        createLinks(node);

        return _nodes[1];
    }

    private void createLinks(Node? sourceNode)
    {
        if (sourceNode == null)
        {
            return;
        }

        var sourceNodeVal = sourceNode.val;
        
        if (_visited.Contains(sourceNodeVal)) return;
        _visited.Add(sourceNodeVal);

        var clonedNode = _nodes[sourceNodeVal];

        foreach (var neighbor in sourceNode.neighbors)
        {
            clonedNode.neighbors.Add(_nodes[neighbor.val]);
            createLinks(neighbor);
        }
    }

    private void createNodes(Node? sourceNode)
    {
        if (sourceNode == null)
        {
            return;
        }

        var sourceNodeVal = sourceNode.val;
        
        if (_nodes.ContainsKey(sourceNodeVal)) return;
        
        _nodes.Add(sourceNodeVal, new Node(sourceNodeVal, new List<Node>()));
        foreach (var neighbor in sourceNode.neighbors)
        {
            createNodes(neighbor);
        }
    }
}