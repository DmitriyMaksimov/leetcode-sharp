namespace leetcode_sharp;

// 999. Available Captures for Rook
// https://leetcode.com/problems/available-captures-for-rook/
public class S00999
{
    private const char Pawn = 'p';

    public int NumRookCaptures(char[][] board)
    {
        var (x, y) = findRook(board);
        var count = 0;

        for (var i = x - 1; i >= 0; i--)
        {
            if (board[i][y] == '.') continue;

            count += board[i][y] == Pawn ? 1 : 0; 
            break;
        }

        for (var i = x + 1; i < board.Length; i++)
        {
            if (board[i][y] == '.') continue;
            
            count += board[i][y] == Pawn ? 1 : 0; 
            break;
        }

        for (var i = y - 1; i >= 0; i--)
        {
            if (board[x][i] == '.') continue;
            
            count += board[x][i] == Pawn ? 1 : 0; 
            break;
        }

        for (var i = y + 1; i < board[0].Length; i++)
        {
            if (board[x][i] == '.') continue;
            
            count += board[x][i] == Pawn ? 1 : 0; 
            break;
        }

        return count;
    }

    private static (int x, int y) findRook(char[][] board)
    {
        const char rook = 'R';

        for (var i = 0; i < board.Length; i++)
        {
            for (var j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == rook)
                {
                    return (i, j);
                }
            }
        }

        return (0, 0);
    }
}