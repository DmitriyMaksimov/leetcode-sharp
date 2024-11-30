namespace leetcode_sharp;

// 447. Number of Boomerangs
// https://leetcode.com/problems/number-of-boomerangs
public class S00447
{
    public int NumberOfBoomerangs(int[][] points)
    {
        var result = 0;

        foreach (var p in points)
        {
            var dictionary = new Dictionary<int, int>();

            foreach (var q in points)
            {
                var f = p[0] - q[0];
                var s = p[1] - q[1];
                var distanceSquared = f * f + s * s;

                dictionary[distanceSquared] = dictionary.GetValueOrDefault(distanceSquared) + 1;
            }

            result += dictionary.Values.Sum(count => count * (count - 1));
        }

        return result;
    }
}
