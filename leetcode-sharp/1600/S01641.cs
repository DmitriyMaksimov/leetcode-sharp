namespace leetcode_sharp;

// 1641. Count Sorted Vowel Strings
// https://leetcode.com/problems/count-sorted-vowel-strings
public class S01641
{
    public int CountVowelStrings(int n)
    {
        return (n + 1) * (n + 2) * (n + 3) * (n + 4) / 24;
    }
}