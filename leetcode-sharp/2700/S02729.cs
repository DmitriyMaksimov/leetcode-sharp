namespace leetcode_sharp;

// 2729. Check if The Number is Fascinating
// https://leetcode.com/problems/check-if-the-number-is-fascinating
public class S02729
{
    public bool IsFascinating(int n)
    {
        var set = new HashSet<int>();
        
        for (var i = 1; i <= 3; i++)
        {
            var num = n * i;
            
            if (num > 999) return false;
        
            while (num != 0)
            {
                set.Add(num % 10);
                num /= 10;
            }
        }

        return set.Count == 9 && !set.Contains(0);
    }
}