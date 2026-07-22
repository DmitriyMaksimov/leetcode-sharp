using System.Text.RegularExpressions;

namespace leetcode_sharp;

// 3501. Maximize Active Section with Trade II
// https://leetcode.com/problems/maximize-active-section-with-trade-ii
public class S03501
{
    private int[] _zeroStarts = [];
    private int[] _zeroEnds = [];
    private int[] _valleyValues = [];
    private readonly List<int[]> _sparseTable = [];

    private int _blockCount;

    public IList<int> MaxActiveSectionsAfterTrade(string s, int[][] queries)
    {
        var activeCount = s.Count(c => c == '1');

        var starts = new List<int>();
        var ends = new List<int>();

        foreach (Match match in Regex.Matches(s, "0+"))
        {
            starts.Add(match.Index);
            ends.Add(match.Index + match.Length - 1);
        }

        _zeroStarts = starts.ToArray();
        _zeroEnds = ends.ToArray();
        _blockCount = _zeroStarts.Length;

        _valleyValues = new int[Math.Max(0, _blockCount - 1)];

        for (var i = 0; i < _valleyValues.Length; i++)
        {
            var leftLength = _zeroEnds[i] - _zeroStarts[i] + 1;
            var rightLength = _zeroEnds[i + 1] - _zeroStarts[i + 1] + 1;

            _valleyValues[i] = leftLength + rightLength;
        }

        BuildSparseTable();

        return queries.Select(query => activeCount + Gain(query[0], query[1])).ToList();
    }

    private void BuildSparseTable()
    {
        _sparseTable.Clear();

        if (_valleyValues.Length == 0)
        {
            return;
        }

        _sparseTable.Add(_valleyValues);

        for (var half = 1; half * 2 <= _valleyValues.Length; half <<= 1)
        {
            var previous = _sparseTable[^1];
            var current = new int[previous.Length - half];

            for (var i = 0; i < current.Length; i++)
            {
                current[i] = Math.Max(previous[i], previous[i + half]);
            }

            _sparseTable.Add(current);
        }
    }

    private int Gain(int left, int right)
    {
        if (_blockCount < 2)
        {
            return 0;
        }

        var firstValley = LowerBound(_zeroEnds, left);
        var lastValley = UpperBound(_zeroStarts, right) - 2;

        if (firstValley > lastValley)
        {
            return 0;
        }

        var best = Math.Max(Clip(firstValley, left, right), Clip(lastValley, left, right));

        if (lastValley - firstValley >= 2)
        {
            best = Math.Max(best, RangeMax(firstValley + 1, lastValley - 1));
        }

        return best;
    }

    private int Clip(int valley, int left, int right)
    {
        return _valleyValues[valley] - Math.Max(0, left - _zeroStarts[valley]) - Math.Max(0, _zeroEnds[valley + 1] - right);
    }

    private int RangeMax(int left, int right)
    {
        var level = (int)Math.Log2(right - left + 1);

        return Math.Max(_sparseTable[level][left], _sparseTable[level][right - (1 << level) + 1]);
    }

    private static int LowerBound(int[] values, int target)
    {
        var lo = 0;
        var hi = values.Length;

        while (lo < hi)
        {
            var mid = lo + (hi - lo) / 2;

            if (values[mid] < target)
            {
                lo = mid + 1;
            }
            else
            {
                hi = mid;
            }
        }

        return lo;
    }

    private static int UpperBound(int[] values, int target)
    {
        var lo = 0;
        var hi = values.Length;

        while (lo < hi)
        {
            var mid = lo + (hi - lo) / 2;

            if (values[mid] <= target)
            {
                lo = mid + 1;
            }
            else
            {
                hi = mid;
            }
        }

        return lo;
    }
}