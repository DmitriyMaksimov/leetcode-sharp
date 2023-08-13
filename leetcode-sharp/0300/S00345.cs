namespace leetcode_sharp;

// 345. Reverse Vowels of a String
// https://leetcode.com/problems/reverse-vowels-of-a-string/
public class S00345
{
    private readonly HashSet<char> _vowels = new() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

    public string ReverseVowels(string s)
    {
        var chars = s.ToCharArray();
        var left = 0;
        var right = s.Length - 1;

        while (left < right)
        {
            if (!_vowels.Contains(chars[left]))
            {
                ++left;
            }

            if (!_vowels.Contains(chars[right]))
            {
                --right;
            }

            if (_vowels.Contains(chars[left]) && _vowels.Contains(chars[right]))
            {
                (chars[left], chars[right]) = (chars[right], chars[left]);
                ++left;
                --right;
            }
        }

        return new string(chars);
    }
}