namespace leetcode_sharp;

// 
// https://leetcode.com/problems/minimum-recolors-to-get-k-consecutive-black-blocks/
public class S02379
{
    public int MinimumRecolors(string blocks, int k)
    {
        var minOps = k;
        var whiteBlocks = new int[blocks.Length];

        // Initialise the counts of 'W's
        for (var i = 0; i < blocks.Length; i++)
        {
            if (i > 0)
            {
                whiteBlocks[i] = whiteBlocks[i - 1];
            }

            if (blocks[i] == 'W')
            {
                whiteBlocks[i]++;
            }
        }

        // We will slide our window of size 'k' from start to end
        for (var i = 0; i <= blocks.Length - k; i++)
        {
            int ops;

            if (i == 0)
            {
                ops = whiteBlocks[i + k - 1];
            }
            else
            {
                ops = whiteBlocks[i + k - 1] - whiteBlocks[i - 1];
            }

            minOps = Math.Min(minOps, ops);
        }

        return minOps;
    }
}