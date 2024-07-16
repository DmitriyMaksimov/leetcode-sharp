using System.Text;

namespace leetcode_sharp;

// 2096. Step-By-Step Directions From a Binary Tree Node to Another
// https://leetcode.com/problems/step-by-step-directions-from-a-binary-tree-node-to-another
public class S02096
{
    public string GetDirections(TreeNode root, int startValue, int destValue)
    {
        var s = new StringBuilder();
        Find(root, startValue, s);

        var d = new StringBuilder();
        Find(root, destValue, d);
        
        var i = 0;
        var maxLength = Math.Min(d.Length, s.Length);
        
        while (i < maxLength && s[s.Length - i - 1] == d[d.Length - i - 1])
        {
            ++i;
        }

        return string.Concat(new string(Enumerable.Repeat('U', s.Length - i).ToArray()), new string(d.ToString().Reverse().ToArray()).AsSpan(i));
    }

    private static bool Find(TreeNode n, int val, StringBuilder sb)
    {
        if (n.val == val)
        {
            return true;
        }

        if (n.left != null && Find(n.left, val, sb))
        {
            sb.Append('L');
        }
        else if (n.right != null && Find(n.right, val, sb))
        {
            sb.Append('R');
        }

        return sb.Length > 0;
    }
}