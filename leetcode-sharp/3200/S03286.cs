namespace leetcode_sharp;

// 3286. Find a Safe Walk Through a Grid
// https://leetcode.com/problems/find-a-safe-walk-through-a-grid
public class S03286
{
    public bool FindSafeWalk(IList<IList<int>> grid, int health)
    {
        var rows = grid.Count;
        var cols = grid[0].Count;
        var visited = new bool[rows, cols];
        var maxHeap = new PriorityQueue<(int Row, int Col, int Health), int>();

        var startHealth = health - grid[0][0];
        maxHeap.Enqueue((0, 0, startHealth), -startHealth);
        visited[0, 0] = true;

        int[] dr = { -1, 0, 1, 0 };
        int[] dc = { 0, 1, 0, -1 };

        while (maxHeap.Count > 0)
        {
            var (row, col, currentHealth) = maxHeap.Dequeue();

            if (row == rows - 1 && col == cols - 1)
            {
                return currentHealth >= 1;
            }

            for (var direction = 0; direction < 4; direction++)
            {
                var newRow = row + dr[direction];
                var newCol = col + dc[direction];

                if (newRow < 0 || newRow >= rows || newCol < 0 || newCol >= cols || visited[newRow, newCol])
                {
                    continue;
                }

                var nextHealth = currentHealth - grid[newRow][newCol];

                visited[newRow, newCol] = true;
                maxHeap.Enqueue((newRow, newCol, nextHealth), -nextHealth);
            }
        }

        return false;
    }
}