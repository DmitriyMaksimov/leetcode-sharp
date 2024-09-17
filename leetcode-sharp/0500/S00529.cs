namespace leetcode_sharp;

// 529. Minesweeper
// https://leetcode.com/problems/minesweeper
public class S00529
{
    private const char Mine = 'M';
    private const char RevealedMine = 'X';
    private const char Empty = 'E';
    private const char Blank = 'B';

    public char[][] UpdateBoard(char[][] board, int[] click)
    {
        var m = board.Length;
        var n = board[0].Length;
        var row = click[0];
        var col = click[1];

        if (board[row][col] == Mine)
        {
            board[row][col] = RevealedMine;
            return board;
        }

        var count = 0;

        for (var i = -1; i < 2; i++)
        {
            for (var j = -1; j < 2; j++)
            {
                var r = row + i;
                var c = col + j;
                if ((i == 0 && j == 0) || r < 0 || r >= m || c < 0 || c >= n)
                {
                    continue;
                }

                if (board[r][c] == Mine || board[r][c] == RevealedMine)
                {
                    count++;
                }
            }
        }

        if (count > 0)
        {
            board[row][col] = (char)('0' + count);
            return board;
        }

        board[row][col] = Blank;

        for (var i = -1; i < 2; i++)
        {
            for (var j = -1; j < 2; j++)
            {
                var r = row + i;
                var c = col + j;
                if ((i == 0 && j == 0) || r < 0 || r >= m || c < 0 || c >= n)
                {
                    continue;
                }

                if (board[r][c] == Empty)
                {
                    UpdateBoard(board, [r, c]);
                }
            }
        }

        return board;
    }
}
