namespace leetcode_sharp;

// 429. N-ary Tree Level Order Traversal
// https://leetcode.com/problems/n-ary-tree-level-order-traversal
public class S00429
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

    public IList<IList<int>> LevelOrder(Node? root)
    {
        if (root == null)
        {
            return new List<IList<int>>();
        }

        List<IList<int>> result = [];
        Queue<Node> queue = [];
        queue.Enqueue(root);

        while (queue.Count != 0)
        {
            List<int> step = [];
            for (var count = queue.Count; count > 0; count--)
            {
                var temp = queue.Dequeue();
                step.Add(temp.val);

                foreach (var child in temp.children ?? [])
                {
                    queue.Enqueue(child);
                }
            }

            result.Add(step);
        }

        return result;
    }
}