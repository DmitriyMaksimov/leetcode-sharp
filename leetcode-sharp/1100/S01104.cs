namespace leetcode_sharp;

// 1104. Path In Zigzag Labelled Binary Tree
// https://leetcode.com/problems/path-in-zigzag-labelled-binary-tree
public class S01104
{
    public IList<int> PathInZigZagTree(int label)
    {
        var result = new LinkedList<int>();
        var parent = label;

        result.AddFirst(parent);

        while (parent != 1)
        {
            var d = (int) (Math.Log(parent) / Math.Log(2));
            var offset = (int) Math.Pow(2, d + 1) - 1 - parent;
            parent = ((int) Math.Pow(2, d) + offset) / 2;

            result.AddFirst(parent);
        }

        return result.ToList();
    }
}