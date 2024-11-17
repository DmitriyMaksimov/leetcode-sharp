namespace leetcode_sharp;

// 449. Serialize and Deserialize BST
// https://leetcode.com/problems/serialize-and-deserialize-bst
public static class S00449
{
    public class Codec
    {
        private const string Separator = "|";

        // Encodes a tree to a single string.
        public string serialize(TreeNode? root)
        {
            return Encode(root);
        }

        // Decodes your encoded data to tree.
        public TreeNode? deserialize(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return null;
            }

            TreeNode? root = null;

            foreach (var item in data.Split(Separator))
            {
                if (!string.IsNullOrEmpty(item))
                {
                    root = Insert(root, int.Parse(item));
                }
            }

            return root;
        }


        private static string Encode(TreeNode? root)
        {
            if (root == null)
            {
                return string.Empty;
            }

            return root.val + Separator + Encode(root.left) + Encode(root.right);
        }

        private static TreeNode Insert(TreeNode? root, int val)
        {
            if (root == null)
            {
                return new TreeNode(val);
            }

            if (val <= root.val)
            {
                root.left = Insert(root.left, val);
            }
            else
            {
                root.right = Insert(root.right, val);
            }

            return root;
        }
    }
}
