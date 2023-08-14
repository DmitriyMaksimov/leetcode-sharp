namespace leetcode_sharp;

// 117. Populating Next Right Pointers in Each Node II
// https://leetcode.com/problems/populating-next-right-pointers-in-each-node-ii/
public class S00117
{
    public class Node
    {
        public int val;
        public Node? left;
        public Node? right;
        public Node? next;

        public Node()
        {
        }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, Node? _left, Node? _right, Node? _next)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }

    public Node? Connect(Node? root)
    {
        if (root == null)
        {
            return root;
        }

        var q = new Queue<Node?>();
        q.Enqueue(root);
        while (q.Count > 0)
        {
            var count = q.Count;
            Node? prev = null;
            
            for (var i = 0; i < count; i++)
            {
                var cur = q.Dequeue();
                if (cur?.right != null)
                {
                    q.Enqueue(cur.right);
                }

                if (cur?.left != null)
                {
                    q.Enqueue(cur.left);
                }

                cur!.next = prev;
                prev = cur;
            }
        }

        return root;
    }
}