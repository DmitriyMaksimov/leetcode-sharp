namespace leetcode_sharp;

// 500. Keyboard Row
// https://leetcode.com/problems/keyboard-row/
public class S00500
{
    public string[] FindWords(string[] words)
    {
        var keyboardRows = new[]
        {
            new HashSet<char>("qwertyuiop"),
            new HashSet<char>("asdfghjkl"),
            new HashSet<char>("zxcvbnm"),
        };

        var result = new List<string>();

        foreach (var word in words)
        {
            var rowIndex = 0;
            for (; rowIndex < keyboardRows.Length; ++rowIndex)
            {
                if (keyboardRows[rowIndex].Contains(char.ToLower(word[0])))
                {
                    break;
                }
            }

            var validWord = true;

            for (var i = 1; i < word.Length; i++)
            {
                if (!keyboardRows[rowIndex].Contains(char.ToLower(word[i])))
                {
                    validWord = false;
                    break;
                }
            }

            if (validWord)
            {
                result.Add(word);
            }
        }

        return result.ToArray();
    }
}