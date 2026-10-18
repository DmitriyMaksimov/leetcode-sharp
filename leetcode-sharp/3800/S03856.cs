namespace leetcode_sharp;

// 3856. Trim Trailing Vowels
// https://leetcode.com/problems/trim-trailing-vowels
public class S03856
{
    public string TrimTrailingVowels(string s)
    {
        return s.TrimEnd('a', 'e', 'i', 'o', 'u');
    }
}