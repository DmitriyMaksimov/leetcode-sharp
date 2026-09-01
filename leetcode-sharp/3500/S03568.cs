namespace leetcode_sharp;

// 3568. Minimum Moves to Clean the Classroom
// https://leetcode.com/problems/minimum-moves-to-clean-the-classroom
public class S03568
{
    private readonly record struct State(int Row, int Col, int Mask, int Energy, int Moves);

    public int MinMoves(string[] classroom, int energy)
    {
        var m = classroom.Length;
        var n = classroom[0].Length;

        // ID for each piece of litter ('L')
        var id = new int[m, n];

        for (var r = 0; r < m; r++)
        {
            for (var c = 0; c < n; c++)
            {
                id[r, c] = -1;
            }
        }

        var litterCount = 0;
        var startRow = 0;
        var startCol = 0;

        for (var r = 0; r < m; r++)
        {
            for (var c = 0; c < n; c++)
            {
                if (classroom[r][c] == 'S')
                {
                    startRow = r;
                    startCol = c;
                }
                else if (classroom[r][c] == 'L')
                {
                    id[r, c] = litterCount++;
                }
            }
        }

        if (litterCount == 0)
        {
            return 0;
        }

        // Mask where all litter has been collected
        var totalMask = (1 << litterCount) - 1;

        // best[row, col, mask] = maximum energy we've had
        // when reaching (row, col) with this mask.
        var best = new int[m, n, 1 << litterCount];

        for (var r = 0; r < m; r++)
        {
            for (var c = 0; c < n; c++)
            {
                for (var mask = 0; mask < (1 << litterCount); mask++)
                {
                    best[r, c, mask] = -1;
                }
            }
        }

        var queue = new Queue<State>();

        best[startRow, startCol, 0] = energy;

        queue.Enqueue(new State(startRow, startCol, 0, energy, 0));

        int[] dr = { -1, 1, 0, 0 };
        int[] dc = { 0, 0, -1, 1 };

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            for (var d = 0; d < 4; d++)
            {
                var nextRow = current.Row + dr[d];
                var nextCol = current.Col + dc[d];

                if (nextRow < 0 || nextRow >= m || nextCol < 0 || nextCol >= n)
                {
                    continue;
                }

                if (classroom[nextRow][nextCol] == 'X')
                {
                    continue;
                }

                var nextEnergy = current.Energy - 1;

                if (nextEnergy < 0)
                {
                    continue;
                }

                var nextMask = current.Mask;

                var cell = classroom[nextRow][nextCol];

                if (cell == 'R')
                {
                    nextEnergy = energy;
                }

                if (cell == 'L')
                {
                    nextMask |= 1 << id[nextRow, nextCol];
                }

                if (nextMask == totalMask)
                {
                    return current.Moves + 1;
                }

                if (nextEnergy <= best[nextRow, nextCol, nextMask])
                {
                    continue;
                }

                best[nextRow, nextCol, nextMask] = nextEnergy;

                queue.Enqueue(new State(nextRow, nextCol, nextMask, nextEnergy, current.Moves + 1));
            }
        }

        return -1;
    }
}