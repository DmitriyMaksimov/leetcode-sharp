namespace leetcode_sharp;

// 748. Shortest Completing Word
// https://leetcode.com/problems/shortest-completing-word/
public class S00748
{
    public string ShortestCompletingWord(string licensePlate, string[] words)
    {
        var dict = new Dictionary<char, int>();

        foreach (var key in licensePlate.Where(char.IsLetter).Select(char.ToLower))
        {
            dict[key] = dict.GetValueOrDefault(key) + 1;
        }

        var result = string.Empty;

        foreach (var word in words)
        {
            var temp = new Dictionary<char, int>(dict);
            foreach (var c in word)
            {
                if (temp.ContainsKey(c))
                {
                    temp[c]--;
                }
            }

            if (temp.Values.All(v => v <= 0))
            {
                if (result == string.Empty || word.Length < result.Length)
                {
                    result = word;
                }
            }
        }

        return result;
    }
}