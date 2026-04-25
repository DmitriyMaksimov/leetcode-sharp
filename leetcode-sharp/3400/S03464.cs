namespace leetcode_sharp;

// 3464. Maximize the Distance Between Points on a Square
// https://leetcode.com/problems/maximize-the-distance-between-points-on-a-square
public class S03464
{
    public int MaxDistance(int side, int[][] points, int k)
    {
        var perimeter = 4L * side;
        var numPoints = points.Length;
        var mappedPositions = new List<long>(numPoints);
        mappedPositions.AddRange(points.Select(point => MapToPerimeter(side, point[0], point[1])));

        mappedPositions.Sort();

        var low = 0L;
        var high = perimeter;

        while (low < high)
        {
            var mid = low + (high - low + 1) / 2;

            if (IsValidDistance(mid, k, mappedPositions, perimeter))
            {
                low = mid;
            }
            else
            {
                high = mid - 1;
            }
        }

        return (int)low;
    }


    private static long MapToPerimeter(int sideLength, int x, int y)
    {
        if (y == sideLength)
        {
            return x;
        }

        if (x == sideLength)
        {
            return sideLength + (sideLength - y);
        }

        if (y == 0)
        {
            return 2L * sideLength + (sideLength - x);
        }

        return 3L * sideLength + y;
    }

    private bool IsValidDistance(long minDistance, int requiredPoints, List<long> mappedPositions, long perimeter)
    {
        var numPoints = mappedPositions.Count;
        var extendedPositions = new long[2 * numPoints];

        for (var i = 0; i < numPoints; i++)
        {
            extendedPositions[i] = mappedPositions[i];
            extendedPositions[i + numPoints] = mappedPositions[i] + perimeter;
        }

        for (var i = 0; i < numPoints; i++)
        {
            if (CanSelectRequiredPoints(i, minDistance, requiredPoints, mappedPositions, extendedPositions, perimeter))
            {
                return true;
            }
        }

        return false;
    }

    private bool CanSelectRequiredPoints(
        int startIndex,
        long minDistance,
        int requiredPoints,
        List<long> mappedPositions,
        long[] extendedPositions,
        long perimeter)
    {
        var selectedCount = 1;
        var previousPosition = mappedPositions[startIndex];
        var currentIndex = startIndex;

        for (var i = 1; i < requiredPoints; i++)
        {
            var targetPosition = previousPosition + minDistance;

            var left = currentIndex + 1;
            var right = startIndex + mappedPositions.Count;

            var nextIndex = LowerBound(extendedPositions, left, right, targetPosition);

            if (nextIndex == right)
            {
                return false;
            }

            selectedCount++;
            previousPosition = extendedPositions[nextIndex];
            currentIndex = nextIndex;
        }

        return selectedCount == requiredPoints && previousPosition - mappedPositions[startIndex] <= perimeter - minDistance;
    }

    private static int LowerBound(long[] array, int left, int right, long target)
    {
        var l = left;
        var r = right;

        while (l < r)
        {
            var mid = l + (r - l) / 2;
            if (array[mid] < target)
            {
                l = mid + 1;
            }
            else
            {
                r = mid;
            }
        }

        return l;
    }
}