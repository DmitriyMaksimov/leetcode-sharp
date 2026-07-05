namespace leetcode_sharp;

// 1301. Number of Paths with Max Score
// https://leetcode.com/problems/number-of-paths-with-max-score
public class S01301
{
    private const int Mod = 1_000_000_007;

    public int[] PathsWithMaxScore(IList<string> board)
    {
        var rows = board.Count;
        var cols = board[0].Length;

        var directions = new (int dRow, int dCol)[]
        {
            (-1, 0),
            (0, -1),
            (-1, -1)
        };

        var pathCounts = new int[rows, cols];
        var maxScores = new int[rows, cols];

        pathCounts[rows - 1, cols - 1] = 1;

        for (var row = rows - 1; row >= 0; row--)
        {
            for (var col = cols - 1; col >= 0; col--)
            {
                if (pathCounts[row, col] == 0)
                {
                    continue;
                }

                foreach (var (dRow, dCol) in directions)
                {
                    var nextRow = row + dRow;
                    var nextCol = col + dCol;

                    if (nextRow < 0 || nextCol < 0)
                    {
                        continue;
                    }

                    var cell = board[nextRow][nextCol];

                    if (cell == 'X')
                    {
                        continue;
                    }

                    var score = maxScores[row, col];

                    if (cell != 'E')
                    {
                        score += cell - '0';
                    }

                    if (score > maxScores[nextRow, nextCol])
                    {
                        maxScores[nextRow, nextCol] = score;
                        pathCounts[nextRow, nextCol] = pathCounts[row, col];
                    }
                    else if (score == maxScores[nextRow, nextCol])
                    {
                        pathCounts[nextRow, nextCol] =
                            (pathCounts[nextRow, nextCol] + pathCounts[row, col]) % Mod;
                    }
                }
            }
        }

        return [maxScores[0, 0], pathCounts[0, 0]];
    }
}