namespace leetcode_sharp;

// 138. Copy List with Random Pointer
// https://leetcode.com/problems/copy-list-with-random-pointer/
public class S00138
{
    public class Node
    {
        public int val;
        public Node? next;
        public Node? random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }

    private Dictionary<Node, Node> map = new();

    public Node? CopyRandomList(Node? head)
    {
        if (head == null)
        {
            return null;
        }

        if (map.TryGetValue(head, out var list))
        {
            return list;
        }

        var newNode = new Node(head.val);
        
        map[head] = newNode;
        newNode.next = CopyRandomList(head.next);
        newNode.random = CopyRandomList(head.random);

        return newNode;
    }
}