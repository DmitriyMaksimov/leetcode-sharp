namespace leetcode_sharp;

// 412. Fizz Buzz
// https://leetcode.com/problems/fizz-buzz/
public class S00412
{
    public IList<string> FizzBuzz(int n)
    {
        return Enumerable.Range(1, n).Select(fooBar).ToArray();
    }

    private static string fooBar(int n)
    {
        if (n % 3 == 0 && n % 5 == 0)
        {
            return "FizzBuzz";
        }

        if (n % 3 == 0)
        {
            return "Fizz";
        }
        
        return n % 5 == 0 ? "Buzz" : n.ToString();
    }
}