namespace leetcode_sharp;

// 2848. Points That Intersect With Cars
// https://leetcode.com/problems/points-that-intersect-with-cars
public class S02848
{
    public int NumberOfPoints(IList<IList<int>> nums)
    {
        var pointsWithinCar = new int[101];

        foreach (var coordinates in nums)
        {
            var start = coordinates[0];
            var end = coordinates[1];

            for (var i = start; i <= end; i++)
            {
                ++pointsWithinCar[i];
            }
        }

        return pointsWithinCar.Count(x => x > 0);
    }
}