namespace leetcode_sharp;

// 3750. Minimum Number of Flips to Reverse Binary String
// https://leetcode.com/problems/minimum-number-of-flips-to-reverse-binary-string
public class S03750
{
    public int MinimumFlips(int n)
    {
        var binary = Convert.ToString(n, 2);
        var reverseBinary = new string(binary.Reverse().ToArray());

        return binary.Where((t, i) => t != reverseBinary[i]).Count();
    }
}