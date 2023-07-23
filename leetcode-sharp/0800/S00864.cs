namespace leetcode_sharp;

// 864. Shortest Path to Get All Keys
// https://leetcode.com/problems/shortest-path-to-get-all-keys/
public class S00864
{
    private readonly int[] _directions = {0, -1, 0, 1, 0};
    private const char Wall = '#';

    public int ShortestPathAllKeys(string[] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        var (startRow, startCol, listOfKeys) = readInitialData(grid);
        var queue = new Queue<(int row, int col, int keys)>();
        var visited = new HashSet<(int row, int col, int keys)>();

        // Add the initial position to the queue
        queue.Enqueue((startRow, startCol, 0));
        // ...and mark it as visited
        visited.Add((startRow, startCol, 0));

        var steps = 0;

        // Perform BFS
        while (queue.Any())
        {
            var size = queue.Count;
            for (var i = 0; i < size; i++)
            {
                var currentState = queue.Dequeue();

                // Check if all keys are collected
                if (currentState.keys == listOfKeys)
                {
                    return steps;
                }

                // Explore in all the four directions
                for (var k = 0; k < _directions.Length - 1; k++)
                {
                    var newRow = currentState.row + _directions[k];
                    var newCol = currentState.col + _directions[k + 1];

                    // Check if the new position is within the grid boundaries
                    if (newRow < 0 || newRow >= m || newCol < 0 || newCol >= n)
                    {
                        // New position is outside of grid boundaries => skip
                        continue;
                    }

                    var newCell = grid[newRow][newCol];

                    if (newCell == Wall)
                    {
                        // Wall => skip
                        continue;
                    }

                    var newKeys = currentState.keys;

                    switch (newCell)
                    {
                        case >= 'a' and <= 'f':
                            // Found key => update the collected keys
                            newKeys |= 1 << (newCell - 'a');
                            break;
                        case >= 'A' and <= 'F' when ((currentState.keys >> (newCell - 'A')) & 1) == 0:
                            // Found lock, but don't have key for it => skip
                            continue;
                    }

                    if (!visited.Contains((newRow, newCol, newKeys)))
                    {
                        // Not visited yet => add to the queue and mark visited
                        queue.Enqueue((newRow, newCol, newKeys));
                        visited.Add((newRow, newCol, newKeys));
                    }
                }
            }

            steps++;
        }

        return -1;
    }

    private static (int startRow, int startCol, int listOfKeys) readInitialData(string[] grid)
    {
        var startRow = 0;
        var startCol = 0;
        var listOfKeys = 0;

        for (var i = 0; i < grid.Length; i++)
        {
            for (var j = 0; j < grid[0].Length; j++)
            {
                var c = grid[i][j];
                if (c == '@')
                {
                    startRow = i;
                    startCol = j;
                }
                else if (c is >= 'a' and <= 'f')
                {
                    listOfKeys |= 1 << (c - 'a');
                }
            }
        }

        return (startRow, startCol, listOfKeys);
    }
}