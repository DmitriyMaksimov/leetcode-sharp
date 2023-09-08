namespace leetcode_sharp;

// 1275. Find Winner on a Tic Tac Toe Game
// https://leetcode.com/problems/find-winner-on-a-tic-tac-toe-game/
public class S01275
{
    public string Tictactoe(int[][] moves)
    {
        var board = new int[3, 3];
        var player = 1;

        foreach (var move in moves)
        {
            board[move[0], move[1]] = player;
            player = -player;
        }

        if (isWinner(board, 1))
        {
            return "A";
        }

        if (isWinner(board, -1))
        {
            return "B";
        }

        return moves.Length == 9 ? "Draw" : "Pending";
    }

    private static bool isWinner(int[,] board, int player)
    {
        for (var i = 0; i < 3; i++)
        {
            if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
            {
                return true;
            }

            if (board[0, i] == player && board[1, i] == player && board[2, i] == player)
            {
                return true;
            }
        }

        if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
        {
            return true;
        }

        if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
        {
            return true;
        }

        return false;
    }
}