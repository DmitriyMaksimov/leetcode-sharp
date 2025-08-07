namespace leetcode_sharp;

// 3363. Find the Maximum Number of Fruits Collected
// https://leetcode.com/problems/find-the-maximum-number-of-fruits-collected
public class S03363
{
    public int MaxCollectedFruits(int[][] fruits)
    {
        var n = fruits.Length;
        var result = 0;

        for (var i = 0; i < n; i++)
        {
            result += fruits[i][i];
        }

        for (var pass = 0; pass < 2; pass++)
        {
            // Transpose the matrix on the second pass
            if (pass == 1)
            {
                for (var i = 0; i < n; i++)
                {
                    for (var j = i + 1; j < n; j++)
                    {
                        (fruits[i][j], fruits[j][i]) = (fruits[j][i], fruits[i][j]);
                    }
                }
            }

            var prev = Enumerable.Repeat(-1, n).ToArray();
            var curr = new int[n];

            prev[n - 1] = fruits[0][n - 1];

            for (var row = 1; row < n - 1; row++)
            {
                Array.Fill(curr, -1);
                for (var col = 0; col < n; col++)
                {
                    if (prev[col] < 0)
                    {
                        continue;
                    }

                    // Move left
                    if (col > 0)
                    {
                        curr[col - 1] = Math.Max(curr[col - 1], prev[col] + fruits[row][col - 1]);
                    }

                    // Move right
                    if (col < n - 1)
                    {
                        curr[col + 1] = Math.Max(curr[col + 1], prev[col] + fruits[row][col + 1]);
                    }

                    // Stay
                    curr[col] = Math.Max(curr[col], prev[col] + fruits[row][col]);
                }

                // Swap current and previous for next iteration
                (prev, curr) = (curr, prev);
            }

            result += prev[n - 1];
        }

        return result;
    }
}