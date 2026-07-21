namespace leetcode_sharp;

// 3499. Maximize Active Section with Trade I
// https://leetcode.com/problems/maximize-active-section-with-trade-i
public class S03499
{
    public int MaxActiveSectionsAfterTrade(string s)
    {
        var oneCount = 0;
        var convertedOne = 0;
        var currentZeroCount = 0;
        var lastZeroCount = 0;

        foreach (var ch in s)
        {
            if (ch == '0')
            {
                currentZeroCount++;
            }
            else
            {
                if (currentZeroCount != 0)
                {
                    lastZeroCount = currentZeroCount;
                }

                currentZeroCount = 0;
                oneCount++;
            }

            convertedOne = Math.Max(convertedOne, currentZeroCount + lastZeroCount);
        }

        if (convertedOne == currentZeroCount || convertedOne == lastZeroCount)
        {
            return oneCount;
        }

        return oneCount + convertedOne;
    }
}