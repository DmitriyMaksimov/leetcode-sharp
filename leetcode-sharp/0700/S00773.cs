namespace leetcode_sharp;

// 773. Sliding Puzzle
// https://leetcode.com/problems/sliding-puzzle
public class S00773
{
    private const string FinalState = "123450";

    private static readonly Dictionary<int, List<int>> Moves = new()
    {
        { 0, [1, 3] },
        { 1, [0, 2, 4] },
        { 2, [1, 5] },
        { 3, [0, 4] },
        { 4, [3, 5, 1] },
        { 5, [4, 2] }
    };

    public int SlidingPuzzle(int[][] board)
    {
        var start = string.Concat(board[0][0], board[0][1], board[0][2], board[1][0], board[1][1], board[1][2]);

        var visited = new Dictionary<string, int> { { start, 0 } };

        var queue = new Queue<(string state, int zeroIndex)>();
        queue.Enqueue((start, start.IndexOf('0')));

        while (queue.Count > 0)
        {
            var (currentState, zeroIndex) = queue.Dequeue();

            if (currentState == FinalState)
            {
                return visited[currentState];
            }

            foreach (var newZeroIndex in Moves[zeroIndex])
            {
                var chars = currentState.ToCharArray();
                (chars[zeroIndex], chars[newZeroIndex]) = (chars[newZeroIndex], chars[zeroIndex]);
                var newState = new string(chars);

                if (!visited.ContainsKey(newState))
                {
                    visited[newState] = visited[currentState] + 1;
                    queue.Enqueue((newState, newZeroIndex));
                }
            }
        }

        return -1;
    }
}
