namespace leetcode_sharp;

// 744. Find Smallest Letter Greater Than Target
// https://leetcode.com/problems/find-smallest-letter-greater-than-target/
public class S00744
{
    public char NextGreatestLetter(char[] letters, char target)
    {
        var n = letters.Length;
        if (target >= letters[n - 1])
        {
            return letters[0];
        }

        var left = 0;
        var right = n - 1;
        
        while (left < right)
        {
            var mid = left + (right - left) / 2;
            if (letters[mid] <= target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return letters[right];
    }
}