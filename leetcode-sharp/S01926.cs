namespace leetcode_sharp;

// 1926. Nearest Exit from Entrance in Maze
// https://leetcode.com/problems/nearest-exit-from-entrance-in-maze/
public class S01926
{
    public int NearestExit(char[][] maze, int[] entrance)
    {
        var rows = maze.Length;
        var cols = maze[0].Length;
        var dirs = new[] {(1, 0), (-1, 0), (0, 1), (0, -1)};
        
        // Mark the entrance as visited
        var startRow = entrance[0];
        var startCol = entrance[1];
        maze[startRow][startCol] = '+';
        
        // BFS from the entrance
        var visited = new Queue<(int, int, int)>();
        visited.Enqueue((startRow, startCol, 0));
        
        while (visited.Count > 0)
        {
            var (currRow, currCol, currDistance) = visited.Dequeue();
            
            foreach (var (rowStep, colStep) in dirs)
            {
                int nextRow = currRow + rowStep, nextCol = currCol + colStep;

                if (0 <= nextRow && nextRow < rows && 0 <= nextCol && nextCol < cols && maze[nextRow][nextCol] == '.')
                {
                    if (nextRow == 0 || nextRow == rows - 1 || nextCol == 0 || nextCol == cols - 1)
                    {
                        // Found exit
                        return currDistance + 1;
                    }

                    maze[nextRow][nextCol] = '+';
                    visited.Enqueue((nextRow, nextCol, currDistance + 1));
                }
            }
        }
        
        return -1;
    }
}