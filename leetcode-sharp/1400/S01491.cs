namespace leetcode_sharp;

// 1491. Average Salary Excluding the Minimum and Maximum Salary
// https://leetcode.com/problems/average-salary-excluding-the-minimum-and-maximum-salary/
public class S01491
{
    public double Average(int[] salary)
    {
        if (salary.Length <= 2)
        {
            return 0;
        }
        
        var min = salary[0];
        var max = salary[0];
        var sum = 0;
        
        foreach (var n in salary)
        {
            max = Math.Max(max, n);
            min = Math.Min(min, n);
            sum += n;
        }

        return (sum - max - min) / (salary.Length - 2.0);
    }
}