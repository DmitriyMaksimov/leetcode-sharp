namespace leetcode_sharp;

// 230. Kth Smallest Element in a BST
// https://leetcode.com/problems/kth-smallest-element-in-a-bst/
public class S00230
{
    private int _answer;
    private int _count;

    public int KthSmallest(TreeNode? root, int k)
    {
        inorder(root, k);
        return _answer;
    }

    private void inorder(TreeNode? root, int k)
    {
        if (root == null)
        {
            return;
        }

        inorder(root.left, k);
        _count++;
        if (_count == k)
        {
            _answer = root.val;
            return;
        }

        inorder(root.right, k);
    }
}