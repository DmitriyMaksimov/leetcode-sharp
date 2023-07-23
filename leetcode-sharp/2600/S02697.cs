namespace leetcode_sharp;

// 2697. Lexicographically Smallest Palindrome
// https://leetcode.com/problems/lexicographically-smallest-palindrome/
public class S02697
{
    public string MakeSmallestPalindrome(string s)
    {
        var chars = s.ToCharArray();

        for (var i = 0; i < chars.Length / 2; i++)
        {
            var rightIndex = ^(i + 1);

            if (chars[i] == chars[rightIndex]) continue;
            
            if (chars[i] > chars[rightIndex])
            {
                chars[i] = chars[rightIndex];
            }
            else
            {
                chars[rightIndex] = chars[i];
            }
        }

        return string.Join("", chars);
    }
}