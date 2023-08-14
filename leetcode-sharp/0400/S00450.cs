namespace leetcode_sharp;

// 450. Delete Node in a BST
// https://leetcode.com/problems/delete-node-in-a-bst/
public class S00450
{
    public TreeNode? DeleteNode(TreeNode? root, int key)
    {
        if (root == null)
        {
            return null;
        }

        if (key < root.val)
        {
            root.left = DeleteNode(root.left, key);
        }
        else if (key > root.val)
        {
            root.right = DeleteNode(root.right, key);
        }
        else
        {
            if (root.left == null)
            {
                return root.right;
            }

            if (root.right == null)
            {
                return root.left;
            }

            var minNode = findMin(root.right);
            root.val = minNode.val;
            root.right = DeleteNode(root.right, root.val);
        }

        return root;
    }

    private static TreeNode findMin(TreeNode node)
    {
        while (node.left != null)
        {
            node = node.left;
        }

        return node;
    }
}