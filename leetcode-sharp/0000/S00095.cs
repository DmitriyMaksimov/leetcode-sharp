namespace leetcode_sharp;

// 95. Unique Binary Search Trees II
// https://leetcode.com/problems/unique-binary-search-trees-ii/
public class S00095
{
    public IList<TreeNode?> GenerateTrees(int n)
    {
        return generateTrees(1, n);
    }

    private static IList<TreeNode?> generateTrees(int start, int end)
    {
        if (start > end) return new List<TreeNode?> {null};

        var result = new List<TreeNode?>();

        for (var i = start; i <= end; i++)
        {
            var left = generateTrees(start, i - 1);
            var right = generateTrees(i + 1, end);

            result.AddRange(from l in left from r in right select new TreeNode(i, l, r));
        }

        return result;
    }
}