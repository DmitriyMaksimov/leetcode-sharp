namespace leetcode_sharp;

// 2131. Longest Palindrome by Concatenating Two Letter Words
// https://leetcode.com/problems/longest-palindrome-by-concatenating-two-letter-words
public class S02131
{
    public int LongestPalindrome(string[] words)
    {
        var nonPaired = new Dictionary<string, int>();
        var pairs = 0;
        var symmetricWords = 0;

        foreach (var word in words)
        {
            var reverse = new string(word.Reverse().ToArray());

            if (nonPaired.TryGetValue(reverse, out var count) && count > 0)
            {
                pairs++;
                nonPaired[reverse] = count - 1;

                if (word[0] == word[1])
                {
                    symmetricWords--;
                }
            }
            else
            {
                nonPaired[word] = nonPaired.GetValueOrDefault(word) + 1;

                if (word[0] == word[1])
                {
                    symmetricWords++;
                }
            }
        }

        return 4 * pairs + (symmetricWords > 0 ? 2 : 0);
    }
}
