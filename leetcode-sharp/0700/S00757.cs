namespace leetcode_sharp;

// 757. Set Intersection Size At Least Two
// https://leetcode.com/problems/set-intersection-size-at-least-two
public class S00757
{
    public int IntersectionSizeTwo(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[1] != b[1] ? a[1].CompareTo(b[1]) : b[0].CompareTo(a[0]));

        var count = 0;
        var largest = -1;
        var second = -1;

        foreach (var interval in intervals)
        {
            var start = interval[0];
            var end = interval[1];

            var largestIn = start <= largest;
            var secondIn = start <= second;

            if (largestIn && secondIn)
            {
                continue;
            }

            count += largestIn ? 1 : 2;

            second = largestIn ? largest : end - 1;
            largest = end;
        }

        return count;
    }
}