namespace leetcode_sharp;

// 3242. Design Neighbor Sum Service
// https://leetcode.com/problems/design-neighbor-sum-service
public class S03242
{
    public class NeighborSum
    {
        private readonly int[][] _grid;
        private readonly Dictionary<int, (int row, int col)> _coords = [];

        public NeighborSum(int[][] grid)
        {
            _grid = grid;
            for (var i = 0; i < grid.Length; i++)
            {
                for (var j = 0; j < grid.Length; j++)
                {
                    _coords[_grid[i][j]] = (i, j);
                }
            }
        }

        public int AdjacentSum(int value)
        {
            var (row, col) = _coords[value];
            var sum = 0;

            if (row > 0)
            {
                sum += _grid[row - 1][col];
            }

            if (row < _grid.Length - 1)
            {
                sum += _grid[row + 1][col];
            }

            if (col > 0)
            {
                sum += _grid[row][col - 1];
            }

            if (col < _grid.Length - 1)
            {
                sum += _grid[row][col + 1];
            }

            return sum;
        }

        public int DiagonalSum(int value)
        {
            var (row, col) = _coords[value];
            var sum = 0;

            if (row > 0 && col > 0)
            {
                sum += _grid[row - 1][col - 1];
            }

            if (row < _grid.Length - 1 && col < _grid.Length - 1)
            {
                sum += _grid[row + 1][col + 1];
            }

            if (col > 0 && row < _grid.Length - 1)
            {
                sum += _grid[row + 1][col - 1];
            }

            if (col < _grid.Length - 1 && row > 0)
            {
                sum += _grid[row - 1][col + 1];
            }

            return sum;
        }
    }
}
