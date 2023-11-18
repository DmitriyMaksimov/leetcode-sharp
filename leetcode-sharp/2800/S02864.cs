namespace leetcode_sharp;

// 2864. Maximum Odd Binary Number
// https://leetcode.com/problems/maximum-odd-binary-number
public class S02864
{
    public string MaximumOddBinaryNumber(string s)
    {
        var ones = s.Count(c => c == '1');
        return new string(Enumerable.Repeat('1', ones - 1).Concat(Enumerable.Repeat('0', s.Length - ones)).Append('1').ToArray()); 
    }
}