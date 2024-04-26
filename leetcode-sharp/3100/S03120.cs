namespace leetcode_sharp;

// 3120. Count the Number of Special Characters I
// https://leetcode.com/problems/count-the-number-of-special-characters-i
public class S03120
{
    public int NumberOfSpecialChars(string word)
    {
        Dictionary<char, int> dictionary = [];

        foreach (var ch in word.Distinct())
        {
            var upperChar = char.ToUpper(ch);
            dictionary[upperChar] = dictionary.GetValueOrDefault(upperChar) + 1;
        }

        return dictionary.Values.Count(count => count == 2);
    }
}