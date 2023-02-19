namespace leetcode_sharp;

// 637. Average of Levels in Binary Tree
// https://leetcode.com/problems/average-of-levels-in-binary-tree/
public class S00637
{
    public IList<double> AverageOfLevels(TreeNode? root)
    {
        if (root == null)
        {
            return new List<double>();
        }

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

        var result = new List<double>();
        
        foreach (var nodes in levels)
        {
            var sum = nodes.Where(x => x != null).Select(x => (long)x.val).Sum();
            result.Add((double)sum / nodes.Count(x => x != null));
        }

        return result;
    }
}