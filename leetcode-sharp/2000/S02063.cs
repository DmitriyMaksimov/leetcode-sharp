namespace leetcode_sharp;

// 2063. Vowels of All Substrings
// https://leetcode.com/problems/vowels-of-all-substrings
public class S02063
{
    public long CountVowels(string word)
    {
        var result = 0L;
        var prev = 0L;

        for (var i = 0; i < word.Length; i++)
        {
            var c = word[i];

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                prev += i + 1;
            }

            result += prev;
        }

        return result;
    }
}
