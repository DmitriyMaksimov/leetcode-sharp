namespace leetcode_sharp;

// 2438. Range Product Queries of Powers
// https://leetcode.com/problems/range-product-queries-of-powers
public class S02438
{
    private const int Mod = 1_000_000_007;

    public int[] ProductQueries(int n, int[][] queries)
    {
        var powers = new List<int>();
        while (n > 0)
        {
            var lowBit = n & -n;
            powers.Add(lowBit);
            n ^= lowBit;
        }

        var size = powers.Count;
        var table = new int[size, size];

        // Precompute products modulo MOD
        for (var row = 0; row < size; row++)
        {
            table[row, row] = powers[row];
            for (var col = row + 1; col < size; col++)
            {
                table[row, col] = (int)((long)table[row, col - 1] * powers[col] % Mod);
            }
        }

        var result = new int[queries.Length];
        for (var i = 0; i < queries.Length; i++)
        {
            var (p, q) = (queries[i][0], queries[i][1]);
            result[i] = table[p, q];
        }

        return result;
    }
}