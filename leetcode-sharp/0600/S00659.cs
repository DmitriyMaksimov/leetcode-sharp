namespace leetcode_sharp;

// 659. Split Array into Consecutive Subsequences
// https://leetcode.com/problems/split-array-into-consecutive-subsequences
public class S00659
{
    public bool IsPossible(int[] nums)
    {
        var previousNumber = int.MinValue;
        var countEndingWithOne = 0;
        var countEndingWithTwo = 0;
        var countEndingWithThreeOrMore = 0;

        var currentNumber = 0;
        var newCountEndingWithOne = 0;
        var newCountEndingWithTwo = 0;
        var newCountEndingWithThreeOrMore = 0;

        for (var i = 0;
             i < nums.Length;
             previousNumber = currentNumber,
             countEndingWithOne = newCountEndingWithOne,
             countEndingWithTwo = newCountEndingWithTwo,
             countEndingWithThreeOrMore = newCountEndingWithThreeOrMore)
        {
            currentNumber = nums[i];
            var currentFrequency = 0;
            while (i < nums.Length && nums[i] == currentNumber)
            {
                currentFrequency++;
                i++;
            }

            if (currentNumber != previousNumber + 1)
            {
                if (countEndingWithOne != 0 || countEndingWithTwo != 0)
                {
                    return false;
                }

                newCountEndingWithOne = currentFrequency;
                newCountEndingWithTwo = 0;
                newCountEndingWithThreeOrMore = 0;
            }
            else
            {
                if (currentFrequency < countEndingWithOne + countEndingWithTwo)
                {
                    return false;
                }

                newCountEndingWithOne = Math.Max(0, currentFrequency - (countEndingWithOne + countEndingWithTwo + countEndingWithThreeOrMore));
                newCountEndingWithTwo = countEndingWithOne;
                newCountEndingWithThreeOrMore = countEndingWithTwo + Math.Min(countEndingWithThreeOrMore, currentFrequency - (countEndingWithOne + countEndingWithTwo));
            }
        }

        return countEndingWithOne == 0 && countEndingWithTwo == 0;
    }
}
