namespace leetcode_sharp;

// 994. Rotting Oranges
// https://leetcode.com/problems/rotting-oranges/
public class S00994
{
    private readonly int[] _directions = {0, -1, 0, 1, 0};

    public int OrangesRotting(int[][] grid)
    {
        const int empty = 0;
        const int fresh = 1;
        const int rotten = 2;

        var m = grid.Length;
        var n = grid[0].Length;
        var numberOfFresh = 0;
        var queue = new Queue<(int col, int row)>();

        for (var col = 0; col < m; ++col)
        {
            for (var row = 0; row < n; ++row)
            {
                if (grid[col][row] == fresh)
                {
                    ++numberOfFresh;
                }
                else if (grid[col][row] == rotten)
                {
                    queue.Enqueue((col, row));
                }
            }
        }

        if (numberOfFresh == 0)
        {
            return 0;
        }

        var result = 0;
        
        while (true)
        {
            var queueNext = new Queue<(int col, int row)>();

            while (queue.Count > 0)
            {
                var (col, row) = queue.Dequeue();
                
                for (var d = 0; d < 4; ++d)
                {
                    var newCol = col + _directions[d];
                    var newRow = row + _directions[d + 1];
                    if (newCol < 0 || newCol >= m || newRow < 0 || newRow >= n) continue;
                    
                    if (grid[newCol][newRow] == fresh)
                    {
                        grid[newCol][newRow] = rotten;
                        queueNext.Enqueue((newCol, newRow));
                        --numberOfFresh;
                    }
                }
            }

            if (queueNext.Count == 0)
            {
                break;
            }

            ++result;
            queue = queueNext;
        }


        return numberOfFresh == 0 ? result : -1;
    }
}