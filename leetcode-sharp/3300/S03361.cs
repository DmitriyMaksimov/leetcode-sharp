namespace leetcode_sharp;

// 3361. Shift Distance Between Two Strings
// https://leetcode.com/problems/shift-distance-between-two-strings
public class S03361
{
    public long ShiftDistance(string s, string t, int[] nextCost, int[] previousCost)
    {
        const int alphabetSize = 26;
        var totalCost = 0L;

        for (var i = 0; i < s.Length; i++)
        {
            var start = s[i] - 'a';
            var end = t[i] - 'a';
            if (start == end)
            {
                continue;
            }

            var forward = (end - start + alphabetSize) % alphabetSize;
            var forwardCost = 0L;
            for (var j = 0; j < forward; j++)
            {
                forwardCost += nextCost[(start + j) % alphabetSize];
            }

            var backward = (start - end + alphabetSize) % alphabetSize;
            var backwardCost = 0L;
            for (var j = 0; j < backward; j++)
            {
                backwardCost += previousCost[(start - j + alphabetSize) % alphabetSize];
            }

            totalCost += Math.Min(forwardCost, backwardCost);
        }

        return totalCost;
    }
}
