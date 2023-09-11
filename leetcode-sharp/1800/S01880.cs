namespace leetcode_sharp;

// 1880. Check if Word Equals Summation of Two Words
// https://leetcode.com/problems/check-if-word-equals-summation-of-two-words/
public class S01880
{
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord)
    {
        return convertToInt(firstWord) + convertToInt(secondWord) == convertToInt(targetWord);
    }

    private static int convertToInt(string targetWord)
    {
        return targetWord.Aggregate(0, (current, c) => current * 10 + (c - 'a'));
    }
}