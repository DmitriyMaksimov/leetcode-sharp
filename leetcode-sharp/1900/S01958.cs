namespace leetcode_sharp;

// 1958. Check if Move is Legal
// https://leetcode.com/problems/check-if-move-is-legal
public class S01958
{
    public bool CheckMove(char[][] board, int rMove, int cMove, char color)
    {
        int[][] dirs =
        [
            [0, 1], [1, 0], [-1, 0], [0, -1],
            [1, 1], [1, -1], [-1, 1], [-1, -1]
        ];

        var oppositeColor = color == 'W' ? 'B' : 'W';

        for (var i = 0; i < 8; i++)
        {
            var x = rMove;
            var y = cMove;
            var count = 1;
            x += dirs[i][0];
            y += dirs[i][1];

            while (x >= 0 && y >= 0 && x < 8 && y < 8 && board[x][y] != '.')
            {
                if (count != 1 && board[x][y] == color)
                {
                    return true;
                }

                if (board[x][y] != oppositeColor)
                {
                    break;
                }

                x += dirs[i][0];
                y += dirs[i][1];
                count++;
            }
        }

        return false;
    }
}
