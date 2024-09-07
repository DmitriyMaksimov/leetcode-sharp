namespace leetcode_sharp;

// 1367. Linked List in Binary Tree
// https://leetcode.com/problems/linked-list-in-binary-tree
public class S01367
{
    public bool IsSubPath(ListNode? head, TreeNode? root)
    {
        if (head == null || root == null)
        {
            return false;
        }

        List<int> a = [head.val];
        List<int> dp = [0];
        var i = 0;
        head = head.next;
        while (head != null)
        {
            while (i > 0 && head.val != a[i])
            {
                i = dp[i - 1];
            }

            if (head.val == a[i])
            {
                ++i;
            }

            a.Add(head.val);
            dp.Add(i);
            head = head.next;
        }

        return Dfs(root, 0, a, dp);
    }

    private static bool Dfs(TreeNode? root, int i, List<int> a, List<int> dp)
    {
        if (root == null)
        {
            return false;
        }

        while (i > 0 && root.val != a[i])
        {
            i = dp[i - 1];
        }

        if (root.val == a[i])
        {
            ++i;
        }

        return i == dp.Count || Dfs(root.left, i, a, dp) || Dfs(root.right, i, a, dp);
    }
}
