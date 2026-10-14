namespace leetcode_sharp;

// 3723. Maximize Sum of Squares of Digits
// https://leetcode.com/problems/maximize-sum-of-squares-of-digits
public class S03723
{
    public string MaxSumOfSquares(int num, int sum)
    {
        var shortest = new string('9', sum / 9) + (sum % 9 > 0 ? (sum % 9).ToString() : "");

        return shortest.Length <= num ? shortest + new string('0', num - shortest.Length) : "";
    }
}