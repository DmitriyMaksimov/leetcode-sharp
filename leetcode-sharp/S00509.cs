namespace leetcode_sharp;

// 509. Fibonacci Number
// https://leetcode.com/problems/fibonacci-number/
public class S00509
{
    public int Fib(int n)
    {
        return n switch
        {
            0 => 0,
            1 => 1,
            _ => Fib(n - 1) + Fib(n - 2)
        };
    }
}