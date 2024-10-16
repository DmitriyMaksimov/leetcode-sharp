namespace leetcode_sharp;

// 2471. Minimum Number of Operations to Sort a Binary Tree by Level
// https://leetcode.com/problems/minimum-number-of-operations-to-sort-a-binary-tree-by-level
public class S02471
{
    public int MinimumOperations(TreeNode root)
    {
        var result = 0;
        List<TreeNode> queue = [root];

        while (queue.Count > 0)
        {
            List<TreeNode> q1 = [];
            List<int> vals = [];

            foreach (var node in queue)
            {
                vals.Add(node.val);

                if (node.left != null)
                {
                    q1.Add(node.left);
                }

                if (node.right != null)
                {
                    q1.Add(node.right);
                }
            }

            var ids = Enumerable.Range(0, queue.Count).ToList();
            ids.Sort((i, j) => vals[i] - vals[j]);

            for (var i = 0; i < ids.Count; ++i)
            {
                for (; ids[i] != i; ++result)
                {
                    (ids[i], ids[ids[i]]) = (ids[ids[i]], ids[i]);
                }
            }

            (queue, q1) = (q1, queue);
        }

        return result;
    }
}
