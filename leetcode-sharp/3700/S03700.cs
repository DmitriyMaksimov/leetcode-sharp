namespace leetcode_sharp;

// 3700. Number of ZigZag Arrays II
// https://leetcode.com/problems/number-of-zigzag-arrays-ii
public class S03700
{
    private const long Mod = 1_000_000_007L;

    private static long[][] CreateMatrix(int size)
    {
        var matrix = new long[size][];

        for (var i = 0; i < size; i++)
        {
            matrix[i] = new long[size];
        }

        return matrix;
    }
    
    private static long[][] Multiply(long[][] a, long[][] b)
    {
        var size = a.Length;
        var c = CreateMatrix(size);

        for (var i = 0; i < size; i++)
        {
            for (var k = 0; k < size; k++)
            {
                if (a[i][k] == 0)
                {
                    continue;
                }

                var current = a[i][k];

                for (var j = 0; j < size; j++)
                {
                    if (b[k][j] == 0)
                    {
                        continue;
                    }

                    c[i][j] = (c[i][j] + current * b[k][j]) % Mod;
                }
            }
        }

        return c;
    }

    public int ZigZagArrays(int n, int l, int r)
    {
        var m = r - l + 1;
        var size = 2 * m;
        var transition = CreateMatrix(size);

        for (var x = 0; x < m; x++)
        {
            for (var y = x + 1; y < m; y++)
            {
                transition[x][m + y] = 1;
            }

            for (var y = 0; y < x; y++)
            {
                transition[m + x][y] = 1;
            }
        }

        var result = new long[size][];

        for (var i = 0; i < size; i++)
        {
            result[i] = new long[size];
            result[i][i] = 1;
        }

        var power = (long)n - 1;

        while (power > 0)
        {
            if ((power & 1) != 0)
            {
                result = Multiply(result, transition);
            }

            transition = Multiply(transition, transition);
            power >>= 1;
        }

        var answer = 0L;

        for (var i = 0; i < size; i++)
        {
            var rowSum = 0L;

            for (var j = 0; j < size; j++)
            {
                rowSum = (rowSum + result[i][j]) % Mod;
            }

            answer = (answer + rowSum) % Mod;
        }

        return (int)answer;
    }
}