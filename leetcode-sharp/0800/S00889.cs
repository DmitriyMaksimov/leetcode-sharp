namespace leetcode_sharp;

// 889. Construct Binary Tree from Preorder and Postorder Traversal
// https://leetcode.com/problems/construct-binary-tree-from-preorder-and-postorder-traversal
public class S00889
{
    private int _preIndex;
    private int _posIndex;

    public TreeNode ConstructFromPrePost(int[] preorder, int[] postorder)
    {
        var root = new TreeNode(preorder[_preIndex++]);
        
        if (root.val != postorder[_posIndex])
        {
            root.left = ConstructFromPrePost(preorder, postorder);
        }

        if (root.val != postorder[_posIndex])
        {
            root.right = ConstructFromPrePost(preorder, postorder);
        }

        _posIndex++;

        return root;
    }
}