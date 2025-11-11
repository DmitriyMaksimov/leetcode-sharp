namespace leetcode_sharp;

// 3542. Minimum Operations to Convert All Elements to Zero
// https://leetcode.com/problems/minimum-operations-to-convert-all-elements-to-zero
public class S03542
{
    public int MinOperations(int[] nums)
    {
        var n = nums.Length;
        var result = 0;
        var isNumEncountered = new bool[100_001];
        var monoStack = new int[n];
        var size = 0;

        foreach (var curr in nums)
        {
            if (curr == 0)
            {
                while (size > 0)
                {
                    isNumEncountered[monoStack[--size]] = false;
                }

                continue;
            }

            while (size > 0 && monoStack[size - 1] > curr)
            {
                isNumEncountered[monoStack[--size]] = false;
            }

            if (!isNumEncountered[curr])
            {
                result++;
                isNumEncountered[curr] = true;
            }

            monoStack[size++] = curr;
        }

        return result;
    }
}