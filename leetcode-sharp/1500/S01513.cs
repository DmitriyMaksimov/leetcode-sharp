namespace leetcode_sharp;

// 1513. Number of Substrings With Only 1s
// https://leetcode.com/problems/number-of-substrings-with-only-1s
public class S01513
{
    public int NumSub(string s)
    {
        const int modulo = 1_000_000_007;
        var result = 0L;

        for (long currentIndex = 0L, sequenceStart = 0L; currentIndex <= s.Length; ++currentIndex)
        {
            if (currentIndex == s.Length || s[(int)currentIndex] == '0')
            {
                var sequenceLength = currentIndex - sequenceStart;
                result = (result + sequenceLength * (sequenceLength + 1) / 2) % modulo;
                sequenceStart = currentIndex + 1;
            }
        }

        return (int)result;
    }
}