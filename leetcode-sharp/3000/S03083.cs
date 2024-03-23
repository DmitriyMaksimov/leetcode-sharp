namespace leetcode_sharp;

// 3083. Existence of a Substring in a String and Its Reverse
// https://leetcode.com/problems/existence-of-a-substring-in-a-string-and-its-reverse
public class S03083
{
    public bool IsSubstringPresent(string s)
    {
        HashSet<string> substrings = [];
        var reverseString = new string(s.Reverse().ToArray());
        
        for (var i = 0; i < reverseString.Length - 1; i++)
        {
            substrings.Add(reverseString[i..(i + 2)]);
        }
        
        for (var i = 0; i < s.Length - 1; i++)
        {
            if (substrings.Contains(s[i..(i + 2)]))
            {
                return true;
            }
        }
        
        return false;
    }

    public bool IsSubstringPresentBruteForce(string s)
    {
        var reverseString = new string(s.Reverse().ToArray());
        
        for (var i = 0; i < s.Length - 1; i++)
        {
            if (reverseString.Contains(s[i..(i + 2)]))
            {
                return true;
            }
        }
        
        return false;
    }
}