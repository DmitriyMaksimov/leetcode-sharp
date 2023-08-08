namespace leetcode_sharp;

// 199. Binary Tree Right Side View
// https://leetcode.com/problems/binary-tree-right-side-view/
public class S00199
{
    public IList<int> RightSideView(TreeNode? root)
    {
        var result = new List<int>();
        rightView(root, result, 0);
        return result;
    }

    private static void rightView(TreeNode? curr, ICollection<int> result, int currDepth)
    {
        if (curr == null)
        {
            return;
        }

        if (currDepth == result.Count)
        {
            result.Add(curr.val);
        }

        rightView(curr.right, result, currDepth + 1);
        rightView(curr.left, result, currDepth + 1);
    }
}