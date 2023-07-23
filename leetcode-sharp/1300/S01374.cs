namespace leetcode_sharp;

// 1374. Generate a String With Characters That Have Odd Counts
// https://leetcode.com/problems/generate-a-string-with-characters-that-have-odd-counts/
public class S01374
{
    public string GenerateTheString(int n)
    {
        return n % 2 == 1 ? new string('a', n) : new string('a', n - 1) + "b";
    }
}