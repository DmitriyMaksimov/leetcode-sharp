namespace leetcode_sharp;

// 103. Binary Tree Zigzag Level Order Traversal
// https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/
public class S00103
{
    public IList<IList<int>>? ZigzagLevelOrder(TreeNode? root)
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
                nextLevel.Add(node!.left);
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

        var oddLevel = true;
        var result = new List<IList<int>>();
        
        foreach (var values in levels.Select(nodes => nodes.Where(x => x != null).Select(x => x!.val)))
        {
            result.Add(oddLevel ? values.ToList() : values.Reverse().ToList());
            oddLevel = !oddLevel;
        }

        return result;
    }
}