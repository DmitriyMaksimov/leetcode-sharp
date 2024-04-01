namespace leetcode_sharp;

// 2196. Create Binary Tree From Descriptions
// https://leetcode.com/problems/create-binary-tree-from-descriptions
public class S02196
{
    public TreeNode? CreateBinaryTree(int[][] descriptions)
    {
        Dictionary<int, TreeNode?> dictionary = [];
        HashSet<int> children = [];

        foreach (var arr in descriptions)
        {
            var parent = arr[0];
            var child = arr[1];
            var isLeft = arr[2];

            children.Add(child);
            
            var node = dictionary.GetValueOrDefault(parent, new TreeNode(parent));
            
            if (isLeft == 1)
            {
                node!.left = dictionary.GetValueOrDefault(child, new TreeNode(child));
                dictionary[child] = node.left;
            }
            else
            {
                node!.right = dictionary.GetValueOrDefault(child, new TreeNode(child));
                dictionary[child] = node.right;
            }

            dictionary[parent] = node;
        }

        var root = -1;
        
        foreach (var arr in descriptions)
        {
            if (!children.Contains(arr[0]))
            {
                root = arr[0];
                break;
            }
        }

        return dictionary.GetValueOrDefault(root, null);
    }
}