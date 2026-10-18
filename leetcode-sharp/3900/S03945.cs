namespace leetcode_sharp;

// 3945. Digit Frequency Score
// https://leetcode.com/problems/digit-frequency-score
public class S03945
{
    public int DigitFrequencyScore(int n)
    {
        var sum = 0;

        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }
        
        return sum;
    }
}