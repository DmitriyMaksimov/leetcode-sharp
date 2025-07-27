namespace leetcode_sharp;

// 1054. Distant Barcodes
// https://leetcode.com/problems/distant-barcodes
public class S01054
{
    public int[] RearrangeBarcodes(int[] barcodes)
    {
        var sortedFrequencies = barcodes
            .GroupBy(b => b)
            .ToDictionary(g => g.Key, g => g.Count())
            .OrderByDescending(kvp => kvp.Value);

        var n = barcodes.Length;
        var result = new int[n];
        var index = 0;

        foreach (var (code, freq) in sortedFrequencies)
        {
            for (var i = 0; i < freq; i++)
            {
                if (index >= n)
                {
                    index = 1;
                }

                result[index] = code;
                index += 2;
            }
        }

        return result;
    }
}