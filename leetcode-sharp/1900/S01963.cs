namespace leetcode_sharp;

// 1963. Minimum Number of Swaps to Make the String Balanced
// https://leetcode.com/problems/minimum-number-of-swaps-to-make-the-string-balanced
public class S01963
{
    public int MinSwaps(string s)
    {
        var stackSize = 0;
        var mismatch = 0;
        
        foreach (var ch in s)
        {
            if (ch == '[')
            {
                stackSize++;
            }
            else
            {
                if (stackSize != 0)
                {
                    stackSize--;
                }
                else
                {
                    mismatch++;
                }
            }
        }

        return (mismatch + 1) / 2;
    }
}