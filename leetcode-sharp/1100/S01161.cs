namespace leetcode_sharp;

// 1161. Maximum Level Sum of a Binary Tree
// https://leetcode.com/problems/maximum-level-sum-of-a-binary-tree/
public class S01161
{
    public int MaxLevelSum(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
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
                nextLevel = [];
            }
            else
            {
                break;
            }
        }

        var sums = levels.Select(nodes => nodes.Where(x => x != null).Select(x => (long) x.val).Sum()).ToList();

        return sums.IndexOf(sums.Max()) + 1;
    }
}