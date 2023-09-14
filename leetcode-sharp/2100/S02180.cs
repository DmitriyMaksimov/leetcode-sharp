namespace leetcode_sharp;

// 2180. Count Integers With Even Digit Sum
// https://leetcode.com/problems/count-integers-with-even-digit-sum/
public class S02180
{
    public int CountEven(int num)
    {
        return Enumerable.Range(1, num).Count(i => i.ToString().Sum(c => c - '0') % 2 == 0);
    }
}