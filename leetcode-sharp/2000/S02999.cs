namespace leetcode_sharp;

// 2999. Count the Number of Powerful Integers
// https://leetcode.com/problems/count-the-number-of-powerful-integers
public class S02999
{
    private long?[,] _memoization = new long?[17, 2];
    private string _xStr = null!;
    private int _xSize;
    private int _indexDifference;
    private string _suffix = null!;
    private int _limit;

    public long NumberOfPowerfulInt(long start, long finish, int limit, string suffix)
    {
        return CountPowerfulIntegers(finish, limit, suffix) - CountPowerfulIntegers(start - 1, limit, suffix);
    }

    private long CountPowerfulIntegers(long x, int limit, string suffix)
    {
        _xStr = x.ToString();
        _xSize = _xStr.Length;
        _suffix = suffix;
        _limit = limit;
        _indexDifference = _xSize - suffix.Length;

        if (_indexDifference < 0)
        {
            return 0;
        }

        _memoization = new long?[17, 2];

        return CountRecursive(0, 1);
    }

    private long CountRecursive(int index, int tight)
    {
        if (index == _xSize)
        {
            return 1;
        }

        if (_memoization[index, tight] != null)
        {
            return _memoization[index, tight]!.Value;
        }

        long answer = 0;

        if (index >= _indexDifference)
        {
            var currentDigit = _suffix[index - _indexDifference] - '0';
            if (currentDigit <= _limit)
            {
                if (tight == 1 && currentDigit <= _xStr[index] - '0')
                {
                    answer += CountRecursive(index + 1, currentDigit == _xStr[index] - '0' ? 1 : 0);
                }
                else if (tight == 0)
                {
                    answer += CountRecursive(index + 1, 0);
                }
            }
        }
        else if (tight == 1)
        {
            var digit = _xStr[index] - '0';
            for (var currentDigit = 0; currentDigit <= Math.Min(_limit, digit); currentDigit++)
            {
                answer += CountRecursive(index + 1, currentDigit == digit ? 1 : 0);
            }
        }
        else
        {
            for (var currentDigit = 0; currentDigit <= _limit; currentDigit++)
            {
                answer += CountRecursive(index + 1, 0);
            }
        }

        _memoization[index, tight] = answer;
        return answer;
    }
}
