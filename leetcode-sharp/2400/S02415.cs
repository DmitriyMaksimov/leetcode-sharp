namespace leetcode_sharp;

// 2415. Reverse Odd Levels of Binary Tree
// https://leetcode.com/problems/reverse-odd-levels-of-binary-tree
public class S02415
{
    public TreeNode? ReverseOddLevels(TreeNode? root)
    {
        var level = new List<TreeNode?> {root};
        var isOddLevel = false;
        
        while (level.Count > 0)
        {
            isOddLevel = !isOddLevel;
            var nextLevel = new List<TreeNode?>();

            foreach (var lvl in level)
            {
                if (lvl!.left != null)
                {
                    nextLevel.Add(lvl.left);
                }

                if (lvl.right != null)
                {
                    nextLevel.Add(lvl.right);
                }
            }

            if (isOddLevel)
            {
                for (var i = 0; i < nextLevel.Count / 2; i++)
                {
                    (nextLevel[i]!.val, nextLevel[nextLevel.Count - 1 - i]!.val) = (nextLevel[nextLevel.Count - 1 - i]!.val, nextLevel[i]!.val);
                }
            }

            level = nextLevel;
        }

        return root;
    }
}