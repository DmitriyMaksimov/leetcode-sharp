namespace leetcode_sharp;

// 655. Print Binary Tree
// https://leetcode.com/problems/print-binary-tree
public class S00655
{
    public IList<IList<string>> PrintTree(TreeNode? root)
    {
        var d = CalcDepth(root, 0);
        List<IList<string>> v = [];

        for (var i = 0; i < d; i++)
        {
            v.Add(Enumerable.Range(0, (1 << d) - 1).Select(_ => "").ToList());
        }

        PrintTree(root, 0, v[0].Count - 1, 0, v);
        return v;
    }

    private static int CalcDepth(TreeNode? r, int depth)
    {
        return r == null ? depth : Math.Max(CalcDepth(r.left, depth + 1), CalcDepth(r.right, depth + 1));
    }

    private static void PrintTree(TreeNode? root, int start, int end, int depth, List<IList<string>> v)
    {
        if (root == null)
        {
            return;
        }

        v[depth][start + (end - start) / 2] = root.val.ToString();

        PrintTree(root.left, start, start + (end - start) / 2, depth + 1, v);

        PrintTree(root.right, start + (end - start) / 2 + 1, end, depth + 1, v);
    }
}
