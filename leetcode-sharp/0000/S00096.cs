namespace UnitTests;

// 96. Unique Binary Search Trees
// https://leetcode.com/problems/unique-binary-search-trees/
public class S00096
{
    public int NumTrees(int n)
    {
        if (n is 0 or 1)
        {
            return 1;
        }

        // Catalan number
        var sum = 0;
        
        for (var i = 1; i <= n; i++)
        {
            sum += NumTrees(i - 1) * NumTrees(n - i);
        }

        return sum;
    }
}