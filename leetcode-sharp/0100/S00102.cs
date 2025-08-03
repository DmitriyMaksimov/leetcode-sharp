namespace leetcode_sharp;

// 102. Binary Tree Level Order Traversal
// https://leetcode.com/problems/binary-tree-level-order-traversal/
public class S00102
{
    public IList<IList<int>>? LevelOrder(TreeNode? root)
    {
        if (root == null)
        {
            return new List<IList<int>>();
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

        return levels.Select(nodes => nodes.Where(x => x != null).Select(x => x.val)).Select(values => values.ToList()).Cast<IList<int>>().ToList();
    }
}