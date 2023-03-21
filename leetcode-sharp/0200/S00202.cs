namespace leetcode_sharp;

// 202. Happy Number
// https://leetcode.com/problems/happy-number/
public class S00202
{
    public bool IsHappy(int n)
    {
        var visited = new HashSet<int>();

        while (n != 1)
        {
            var nextNumber = 0;
            while (n != 0)
            {
                var lastDigit = n % 10;
                nextNumber += lastDigit * lastDigit;
                n /= 10;
            }

            if (visited.Contains(nextNumber))
            {
                return false;
            }

            visited.Add(nextNumber);
            
            n = nextNumber;
        }
        
        return true;
    }
}