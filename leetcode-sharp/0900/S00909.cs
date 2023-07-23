namespace leetcode_sharp;

// 909. Snakes and Ladders
// https://leetcode.com/problems/snakes-and-ladders/
public class S00909
{
    public int SnakesAndLadders(int[][] board)
    {
        var n = board.Length;
        Queue<int> queue = new();
        queue.Enqueue(1);
        var visited = new bool[n * n + 1];
        for (var move = 0; queue.Any(); move++)
        {
            for (var size = queue.Count; size > 0; size--)
            {
                var num = queue.Dequeue();
                if (visited[num]) continue;
                visited[num] = true;
                if (num == n * n) return move;
                for (var i = 1; i <= 6 && num + i <= n * n; i++)
                {
                    var next = num + i;
                    var value = getBoardValue(board, next);
                    if (value > 0) next = value;
                    if (!visited[next]) queue.Enqueue(next);
                }
            }
        }

        return -1;
    }

    private static int getBoardValue(int[][] board, int num)
    {
        var n = board.Length;
        var r = (num - 1) / n;
        var x = n - 1 - r;
        var y = r % 2 == 0 ? num - 1 - r * n : n + r * n - num;
        return board[x][y];
    }
}