namespace leetcode_sharp;

// 2018. Check if Word Can Be Placed In Crossword
// https://leetcode.com/problems/check-if-word-can-be-placed-in-crossword
public class S02018
{
    private readonly int[] _directions = [0, -1, 0, 1, 0];

    public bool PlaceWordInCrossword(char[][] board, string word)
    {
        var n = board.Length;
        var m = board[0].Length;

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                if (board[i][j] != ' ' && board[i][j] != word[0])
                {
                    continue;
                }

                for (var d = 0; d < _directions.Length - 1; d++)
                {
                    var row = i;
                    var col = j;
                    var index = 0;

                    if (InBounds(board, row - _directions[d], col - _directions[d + 1]) && board[row - _directions[d]][col - _directions[d + 1]] != '#')
                    {
                        continue;
                    }

                    while (index < word.Length && InBounds(board, row, col))
                    {
                        if (board[row][col] == '#' || (board[row][col] != ' ' && board[row][col] != word[index]))
                        {
                            break;
                        }

                        index++;
                        row += _directions[d];
                        col += _directions[d + 1];
                    }

                    if (index == word.Length && (!InBounds(board, row, col) || board[row][col] == '#'))
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }

    private static bool InBounds(char[][] board, int row, int col)
    {
        return row >= 0 && col >= 0 && row < board.Length && col < board[0].Length;
    }
}
