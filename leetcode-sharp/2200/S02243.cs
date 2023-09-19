namespace leetcode_sharp;

// 2243. Calculate Digit Sum of a String
// https://leetcode.com/problems/calculate-digit-sum-of-a-string/
public class S02243
{
    public string DigitSum(string s, int k)
    {
        for (; s.Length > k;)
        {
            var res = "";

            for (var i = 0; i < s.Length;)
            {
                var sum = 0;
                var j = i;

                for (; j < i + k && j < s.Length; j++)
                {
                    sum += s[j] - '0';
                }

                res += sum.ToString();
                i = j;
            }

            s = res;
        }

        return s;
    }
}