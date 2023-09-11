namespace leetcode_sharp;

// 1869. Longer Contiguous Segments of Ones than Zeros
// https://leetcode.com/problems/longer-contiguous-segments-of-ones-than-zeros/
public class S01869
{
    public bool CheckZeroOnes(string s)
    {
        var maxOnes = 0;
        var maxZeros = 0;
        var ones = 0;
        var zeros = 0;

        foreach (var c in s)
        {
            if (c == '1')
            {
                ones++;
                maxOnes = Math.Max(maxOnes, ones);
                zeros = 0;
            }
            else
            {
                zeros++;
                maxZeros = Math.Max(maxZeros, zeros);
                ones = 0;
            }
        }

        return maxOnes > maxZeros;
    }
}