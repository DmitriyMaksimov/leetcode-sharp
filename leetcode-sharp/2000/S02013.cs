namespace leetcode_sharp;

// 2013. Detect Squares
// https://leetcode.com/problems/detect-squares
public static class S02013
{
    public class DetectSquares
    {
        private readonly List<int[]> _coordinates = [];
        private readonly Dictionary<string, int> _counts = new();

        public void Add(int[] point)
        {
            _coordinates.Add(point);

            var key = $"{point[0]}_{point[1]}";
            _counts[key] = _counts.GetValueOrDefault(key) + 1;
        }

        public int Count(int[] point)
        {
            var count = 0;
            var px = point[0];
            var py = point[1];

            foreach (var coordinate in _coordinates)
            {
                var x = coordinate[0];
                var y = coordinate[1];

                if (px == x || py == y || Math.Abs(px - x) != Math.Abs(py - y))
                {
                    continue;
                }

                count += _counts.GetValueOrDefault($"{x}_{py}") * _counts.GetValueOrDefault($"{px}_{y}");
            }

            return count;
        }
    }
}
