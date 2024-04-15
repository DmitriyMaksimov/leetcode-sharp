namespace leetcode_sharp;

// 537. Complex Number Multiplication
// https://leetcode.com/problems/complex-number-multiplication
public class S00537
{
    public string ComplexNumberMultiply(string num1, string num2)
    {
        var (realA, imagA) = Parse(num1);
        var (realB, imagB) = Parse(num2);

        return $"{realA * realB - imagA * imagB}+{realA * imagB  + realB * imagA}i";
    }
    
    private static (int real, int imaginary) Parse(string num)
    {
        var n = num.IndexOf('+');
        var real = int.Parse(num[.. n]);
        var imaginary = int.Parse(num[(n+1)..^1]);
        return (real, imaginary);
    } 
}