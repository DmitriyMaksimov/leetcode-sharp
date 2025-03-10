namespace leetcode_sharp;

// 3306. Count of Substrings Containing Every Vowel and K Consonants II
// https://leetcode.com/problems/count-of-substrings-containing-every-vowel-and-k-consonants-ii
public class S03306
{
    public long CountOfSubstrings(string word, int k)
    {
        return CountAtLeastMConsonants(word, k) - CountAtLeastMConsonants(word, k + 1);
    }

    private long CountAtLeastMConsonants(string word, int m)
    {
        var n = word.Length;
        HashSet<char> vowels = ['a', 'e', 'i', 'o', 'u'];
        Dictionary<char, long> vowelMap = [];
        var numConsonants = 0;
        var result = 0L;
        var left = 0;
        var right = 0;

        while (right < n || left < n)
        {
            if (vowelMap.Count == vowels.Count && numConsonants >= m)
            {
                result += n - right + 1;
                if (!vowels.Contains(word[left]))
                {
                    numConsonants--;
                }
                else
                {
                    if (vowelMap.TryGetValue(word[left], out var value))
                    {
                        vowelMap[word[left]] = --value;
                        if (value == 0)
                        {
                            vowelMap.Remove(word[left]);
                        }
                    }
                }

                left++;
            }
            else
            {
                if (right == n)
                {
                    break;
                }

                if (!vowels.Contains(word[right]))
                {
                    numConsonants++;
                }
                else
                {
                    vowelMap[word[right]] = vowelMap.GetValueOrDefault(word[right]) + 1;
                }

                right++;
            }
        }

        return result;
    }
}
