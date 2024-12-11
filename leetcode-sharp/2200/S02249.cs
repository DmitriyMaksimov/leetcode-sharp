namespace leetcode_sharp;

// 2249. Count Lattice Points Inside a Circle
// https://leetcode.com/problems/count-lattice-points-inside-a-circle
public class S02249
{
    public int CountLatticePoints(int[][] circles)
    {
        var hashSet = new HashSet<string>();

        foreach (var circle in circles)
        {
            var x = circle[0];
            var y = circle[1];
            var r = circle[2];
            var rSquare = r * r;

            for (var i = x - r; i <= x + r; i++)
            {
                for (var j = y - r; j <= y + r; j++)
                {
                    var key = $"{i}_{j}";

                    if (hashSet.Contains(key))
                    {
                        continue;
                    }

                    if ((x - i) * (x - i) + (y - j) * (y - j) <= rSquare)
                    {
                        hashSet.Add(key);
                    }
                }
            }
        }

        return hashSet.Count;
    }
}
