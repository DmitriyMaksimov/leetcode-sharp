namespace leetcode_sharp;

// 419. Battleships in a Board
// https://leetcode.com/problems/battleships-in-a-board
public class S00419
{
    public int CountBattleships(char[][] board)
    {
        var m = board.Length;
        var n = board[0].Length;
        
        if (m == 0) return 0;

        var count = 0;

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (board[i][j] == '.') continue;
                if (i > 0 && board[i - 1][j] == 'X') continue;
                if (j > 0 && board[i][j - 1] == 'X') continue;
                count++;
            }
        }

        return count;
    }
}