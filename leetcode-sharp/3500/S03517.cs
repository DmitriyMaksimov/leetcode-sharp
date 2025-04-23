namespace leetcode_sharp;

// 3517. Smallest Palindromic Rearrangement I
// https://leetcode.com/problems/smallest-palindromic-rearrangement-i
public class S03517
{
    public string SmallestPalindrome(string s)
    {
        var n = s.Length;
        var m = n / 2;

        if (n is 1 or 2)
        {
            return s;
        }

        var sortedChars = s[..m].ToArray().Order();
        var firstHalf = new string(sortedChars.ToArray());
        var secondHalf = new string(sortedChars.Reverse().ToArray());

        if (n % 2 == 1)
        {
            firstHalf += s[m];
        }

        return firstHalf + secondHalf;
    }
}
