﻿namespace leetcode_sharp;

// 107. Binary Tree Level Order Traversal II
// https://leetcode.com/problems/binary-tree-level-order-traversal-ii/
public class S00107
{
    public IList<IList<int>>? LevelOrderBottom(TreeNode? root)
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
                nextLevel = new List<TreeNode?>();
            }
            else
            {
                break;
            }
        }

        levels.Reverse();
        return levels.Select(nodes => nodes.Where(x => x != null).Select(x => x.val)).Select(values => values.ToList()).Cast<IList<int>>().ToList();
    }
}