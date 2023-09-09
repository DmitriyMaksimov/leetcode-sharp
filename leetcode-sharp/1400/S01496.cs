namespace leetcode_sharp;

// 1496. Path Crossing
// https://leetcode.com/problems/path-crossing/
public class S01496
{
    public bool IsPathCrossing(string path)
    {
        var visited = new HashSet<(int x, int y)>();

        (int x, int y) current = (0, 0);
        visited.Add(current);

        foreach (var c in path)
        {
            current = c switch
            {
                'N' => (current.x, current.y + 1),
                'S' => (current.x, current.y - 1),
                'E' => (current.x + 1, current.y),
                'W' => (current.x - 1, current.y),
                _ => current
            };

            if (visited.Contains(current))
            {
                return true;
            }

            visited.Add(current);
        }

        return false;
    }
}