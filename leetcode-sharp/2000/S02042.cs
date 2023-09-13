namespace leetcode_sharp;

// 2042. Check if Numbers Are Ascending in a Sentence
// https://leetcode.com/problems/check-if-numbers-are-ascending-in-a-sentence/
public class S02042
{
    public bool AreNumbersAscending(string s)
    {
        var numbers = new List<int>();

        foreach (var word in s.Split(' '))
        {
            if (int.TryParse(word, out var number))
            {
                numbers.Add(number);
            }
        }

        for (var i = 1; i < numbers.Count; i++)
        {
            if (numbers[i - 1] >= numbers[i])
            {
                return false;
            }
        }

        return true;
    }
}