namespace leetcode_sharp;

// 1609. Even Odd Tree
// https://leetcode.com/problems/even-odd-tree
public class S01609
{
    public bool IsEvenOddTree(TreeNode? root)
    {
        if (root == null)
        {
            return true;
        }

        Queue<TreeNode> q = [];
        q.Enqueue(root);

        var even = true;

        while (q.Count > 0)
        {
            var count = q.Count;
            var prevValue = even ? int.MinValue : int.MaxValue;

            while (count-- > 0)
            {
                root = q.Dequeue();
                if (even && (root.val % 2 == 0 || root.val <= prevValue))
                {
                    return false;
                }

                if (!even && (root.val % 2 == 1 || root.val >= prevValue))
                {
                    return false;
                }

                prevValue = root.val;
                
                if (root.left != null)
                {
                    q.Enqueue(root.left);
                }

                if (root.right != null)
                {
                    q.Enqueue(root.right);
                }
            }

            even = !even;
        }

        return true;
    }
}