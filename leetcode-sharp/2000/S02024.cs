namespace leetcode_sharp;

// 2024. Maximize the Confusion of an Exam
// https://leetcode.com/problems/maximize-the-confusion-of-an-exam/
public class S02024
{
    public int MaxConsecutiveAnswers(string answerKey, int k)
    {
        var maxFreq = 0;
        var left = 0;
        var charCount = new Dictionary<char, int>();

        for (var right = 0; right < answerKey.Length; right++)
        {
            var currentChar = answerKey[right];
            charCount[currentChar] = charCount.GetValueOrDefault(currentChar) + 1;
            maxFreq = Math.Max(maxFreq, charCount[currentChar]);

            if (right - left + 1 > maxFreq + k)
            {
                charCount[answerKey[left]] = charCount.GetValueOrDefault(answerKey[left]) - 1;
                left++;
            }
        }

        return answerKey.Length - left;
    }
}