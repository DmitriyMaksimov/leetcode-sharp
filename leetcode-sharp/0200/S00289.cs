namespace leetcode_sharp;

// 289. Game of Life
// https://leetcode.com/problems/game-of-life/
public class S00289
{
    public void GameOfLife(int[][] board)
    {
        if (board.Length == 0)
        {
            return;
        }

        var m = board.Length;
        var n = board[0].Length;

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                var lives = liveNeighbors(board, m, n, i, j);

                if (board[i][j] == 1 && lives is >= 2 and <= 3)
                {
                    board[i][j] = 0b11;
                }

                if (board[i][j] == 0 && lives == 3)
                {
                    board[i][j] = 0b10;
                }
            }
        }

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                board[i][j] >>= 1;
            }
        }
    }

    private static int liveNeighbors(int[][] board, int m, int n, int i, int j)
    {
        var lives = 0;
        
        for (var x = Math.Max(i - 1, 0); x <= Math.Min(i + 1, m - 1); x++)
        {
            for (var y = Math.Max(j - 1, 0); y <= Math.Min(j + 1, n - 1); y++)
            {
                lives += board[x][y] & 1;
            }
        }

        lives -= board[i][j] & 1;

        return lives;
    }
}