namespace leetcode_sharp;

// 3753. Total Waviness of Numbers in Range II
// https://leetcode.com/problems/total-waviness-of-numbers-in-range-ii
public class S03753
{
    private string _digits = string.Empty;

    // [idx][prevPrev][prev][tight][leadingZero][result]
    private long[,,,,,] _dp = null!;
    private bool[,,,,] _visited = null!;

    public long TotalWaviness(long num1, long num2)
    {
        return Calculate(num2) - Calculate(num1 - 1);
    }

    private long Calculate(long number)
    {
        if (number < 100)
        {
            return 0;
        }

        _digits = number.ToString();
        _dp = new long[18, 11, 11, 2, 2, 2];
        _visited = new bool[18, 11, 11, 2, 2];

        return Solve(0, 10, 10, true, true).Waviness;
    }

    private (long Count, long Waviness) Solve(int index, int prevPrevDigit, int prevDigit, bool isTight, bool isLeadingZero)
    {
        if (index == _digits.Length)
        {
            return (1, 0);
        }

        var tightIndex = isTight ? 1 : 0;
        var leadingIndex = isLeadingZero ? 1 : 0;

        if (_visited[index, prevPrevDigit, prevDigit, tightIndex, leadingIndex])
        {
            return (
                _dp[index, prevPrevDigit, prevDigit, tightIndex, leadingIndex, 0],
                _dp[index, prevPrevDigit, prevDigit, tightIndex, leadingIndex, 1]
            );
        }

        _visited[index, prevPrevDigit, prevDigit, tightIndex, leadingIndex] = true;

        var totalCount = 0L;
        var totalWaviness = 0L;

        var limit = isTight ? _digits[index] - '0' : 9;

        for (var digit = 0; digit <= limit; digit++)
        {
            var nextTight = isTight && digit == limit;
            var nextLeadingZero = isLeadingZero && digit == 0;

            var nextPrevDigit = nextLeadingZero ? 10 : digit;

            var nextPrevPrevDigit = nextLeadingZero
                ? 10
                : isLeadingZero
                    ? 10
                    : prevDigit;

            var createsWave =
                prevPrevDigit != 10 &&
                prevDigit != 10 &&
                (
                    (prevPrevDigit < prevDigit && prevDigit > digit) ||
                    (prevPrevDigit > prevDigit && prevDigit < digit)
                );

            var (count, waviness) = Solve(index + 1, nextPrevPrevDigit, nextPrevDigit, nextTight, nextLeadingZero);

            totalCount += count;
            totalWaviness += waviness + (createsWave ? count : 0);
        }

        _dp[index, prevPrevDigit, prevDigit, tightIndex, leadingIndex, 0] = totalCount;
        _dp[index, prevPrevDigit, prevDigit, tightIndex, leadingIndex, 1] = totalWaviness;

        return (totalCount, totalWaviness);
    }
}