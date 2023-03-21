namespace leetcode_sharp;

// 953. Verifying an Alien Dictionary
// https://leetcode.com/problems/verifying-an-alien-dictionary/
public class S00953
{
    public bool IsAlienSorted(string[] words, string order)
    {
        var orderDict = new Dictionary<char, int>();
        
        for (var i = 0; i < order.Length; i++)
        {
            orderDict[order[i]] = i;
        }

        for (var i = 1; i < words.Length; i++)
        {
            for (int j = 0; j < words[i - 1].Length; j++)
            {
                if (j >= words[i].Length)
                {
                    // Shorter word
                    return false;
                }

                if (words[i - 1][j] != words[i][j])
                {
                    if (orderDict[words[i - 1][j]] > orderDict[words[i][j]])
                    {
                        return false;
                    }

                    // Current word is sorter => move to next word
                    break;
                }
            }

        }

        return true;
    }
}