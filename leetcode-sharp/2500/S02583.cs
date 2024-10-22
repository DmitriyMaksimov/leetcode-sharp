namespace leetcode_sharp;

// 2583. Kth Largest Sum in a Binary Tree
// https://leetcode.com/problems/kth-largest-sum-in-a-binary-tree
public class S02583
{
    public long KthLargestLevelSum(TreeNode? root, int k)
    {
        if (root == null)
        {
            return -1;
        }

        var queue = new Queue<TreeNode?>();
        var minHeap = new PriorityQueue<long, long>(Comparer<long>.Create((x, y) => x.CompareTo(y)));

        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var n = queue.Count;
            long sum = 0;

            for (var i = 0; i < n; i++)
            {
                var x = queue.Dequeue();
                sum += x!.val;

                if (x.left != null)
                {
                    queue.Enqueue(x.left);
                }

                if (x.right != null)
                {
                    queue.Enqueue(x.right);
                }
            }

            minHeap.Enqueue(sum, sum);

            if (minHeap.Count > k)
            {
                minHeap.Dequeue();
            }
        }

        if (minHeap.Count < k)
        {
            return -1;
        }

        return minHeap.Dequeue();
    }
}
