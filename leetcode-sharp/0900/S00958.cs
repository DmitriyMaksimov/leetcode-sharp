namespace leetcode_sharp;

// 958. Check Completeness of a Binary Tree
// https://leetcode.com/problems/check-completeness-of-a-binary-tree/
public class S00958
{
    public bool IsCompleteTree(TreeNode? root)
    {
        if (root == null)
        {
            return true;
        }

        var levels = buildLevels(root);

        // All levels but last should be "full" => no nulls
        for (var i = 0; i < levels.Count - 1; i++)
        {
            if (levels[i].Any(x => x is null))
            {
                return false;
            }
        }

        // Now check last level - it should have nulls only at the end
        var lastLevel = levels.Last();

        var foundNull = false;
        
        foreach (var node in lastLevel)
        {
            if (node is null)
            {
                foundNull = true;
            }
            else
            {
                if (foundNull)
                {
                    return false;
                }
            }
        }

        return true;
    }

    private static List<List<TreeNode?>> buildLevels(TreeNode root)
    {
        var currentLevel = new List<TreeNode?> {root};
        var nextLevel = new List<TreeNode?>();
        var levels = new List<List<TreeNode?>> {currentLevel};

        while (true)
        {
            foreach (var node in currentLevel.Where(node => node != null))
            {
                nextLevel.Add(node.left);
                nextLevel.Add(node.right);
            }

            if (nextLevel.Any(x => x != null))
            {
                levels.Add(nextLevel);
                currentLevel = nextLevel;
                nextLevel = new List<TreeNode?>();
            }
            else
            {
                break;
            }
        }

        return levels;
    }
}