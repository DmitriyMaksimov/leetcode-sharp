namespace leetcode_sharp;

// 1028. Recover a Tree From Preorder Traversal
// https://leetcode.com/problems/recover-a-tree-from-preorder-traversal/
public class S01028
{
    public TreeNode RecoverFromPreorder(string traversal)
    {
        var stack = new Stack<TreeNode>();
        
        for (var i = 0; i < traversal.Length;)
        {
            int level;
            for (level = 0; traversal[i] == '-'; i++)
            {
                level++;
            }

            int value;
            for (value = 0; i < traversal.Length && traversal[i] != '-'; i++)
            {
                value = value * 10 + (traversal[i] - '0');
            }

            while (stack.Count > level)
            {
                stack.Pop();
            }

            var node = new TreeNode(value);
            if (stack.Any())
            {
                if (stack.Peek().left == null)
                {
                    stack.Peek().left = node;
                }
                else
                {
                    stack.Peek().right = node;
                }
            }

            stack.Push(node);
        }

        return stack.Last();
    }
}