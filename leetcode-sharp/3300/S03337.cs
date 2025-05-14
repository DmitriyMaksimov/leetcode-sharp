namespace leetcode_sharp;

// 3337. Total Characters in String After Transformations II
// https://leetcode.com/problems/total-characters-in-string-after-transformations-ii
public class S03337
{
    private const int Mod = 1_000_000_007;
    private const int AlphabetSize = 26;

    public int LengthAfterTransformations(string s, int t, IList<int> nums)
    {
        var frequencies = new long[AlphabetSize];
        foreach (var c in s)
        {
            frequencies[c - 'a']++;
        }

        var transform = CreateMatrix();

        for (var i = 0; i < AlphabetSize; ++i)
        {
            for (var j = 1; j <= nums[i]; ++j)
            {
                transform[(i + j) % AlphabetSize][i]++;
            }
        }

        var poweredTransform = MatrixExp(transform, t);
        var ans = new List<long>(new long[AlphabetSize]);

        for (var i = 0; i < AlphabetSize; ++i)
        {
            for (var j = 0; j < AlphabetSize; ++j)
            {
                ans[i] = (ans[i] + poweredTransform[i][j] * frequencies[j]) % Mod;
            }
        }

        long sum = 0;
        for (var i = 0; i < AlphabetSize; ++i)
        {
            sum = (sum + ans[i]) % Mod;
        }

        return (int)sum;
    }

    private static List<List<long>> CreateMatrix()
    {
        var matrix = new List<List<long>>(AlphabetSize);

        for (var i = 0; i < AlphabetSize; i++)
        {
            var row = Enumerable.Repeat(0L, AlphabetSize).ToList();
            matrix.Add(row);
        }

        return matrix;
    }

    private static List<List<long>> Multiply(List<List<long>> a, List<List<long>> b)
    {
        var result = CreateMatrix();

        for (var i = 0; i < AlphabetSize; ++i)
        {
            for (var j = 0; j < AlphabetSize; ++j)
            {
                for (var k = 0; k < AlphabetSize; ++k)
                {
                    result[i][j] = (result[i][j] + a[i][k] * b[k][j]) % Mod;
                }
            }
        }

        return result;
    }

    private static List<List<long>> MatrixExp(List<List<long>> baseMatrix, int exp)
    {
        var result = CreateMatrix();

        for (var i = 0; i < AlphabetSize; ++i)
        {
            result[i][i] = 1;
        }

        while (exp > 0)
        {
            if (exp % 2 == 1)
            {
                result = Multiply(result, baseMatrix);
            }

            baseMatrix = Multiply(baseMatrix, baseMatrix);
            exp /= 2;
        }

        return result;
    }
}
