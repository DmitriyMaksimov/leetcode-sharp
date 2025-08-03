namespace leetcode_sharp;

// 662. Maximum Width of Binary Tree
// https://leetcode.com/problems/maximum-width-of-binary-tree/
public class S00662
{
    public int WidthOfBinaryTree(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        var queue = new Queue<TreeNode>();
        var hashMap = new Dictionary<TreeNode, int> {[root] = 1};

        queue.Enqueue(root);
        
        var maxWidth = 0;
        
        while (queue.Count != 0)
        {
            var size = queue.Count;
            var start = 0;
            var end = 0;
            
            for (var i = 0; i < size; i++)
            {
                var node = queue.Dequeue();
                if (i == 0)
                {
                    start = hashMap[node];
                }

                if (i == size - 1)
                {
                    end = hashMap[node];
                }

                if (node.left != null)
                {
                    hashMap[node.left] = hashMap[node] * 2;
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    hashMap[node.right] = hashMap[node] * 2 + 1;
                    queue.Enqueue(node.right);
                }
            }

            maxWidth = Math.Max(end - start + 1, maxWidth);
        }

        return maxWidth;
    }
}