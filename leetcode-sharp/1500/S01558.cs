namespace leetcode_sharp;

// 1558. Minimum Numbers of Function Calls to Make Target Array
// https://leetcode.com/problems/minimum-numbers-of-function-calls-to-make-target-array
public class S01558
{
    public int MinOperations(int[] nums)
    {
        var addOneOperations = 0;
        var highestSetBit = 0;

        for (var bit = 0; bit <= 30; ++bit)
        {
            foreach (var num in nums)
            {
                if ((num & (1 << bit)) != 0)
                {
                    addOneOperations++;
                    highestSetBit = bit;
                }
            }
        }

        return addOneOperations + highestSetBit;
    }
}
