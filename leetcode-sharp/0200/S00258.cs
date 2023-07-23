namespace leetcode_sharp;

// 258. Add Digits
// https://leetcode.com/problems/add-digits/
public class S00258
{
    public int AddDigits(int num)
    {
        return num == 0 ? 0 : (num - 1) % 9 + 1;
    }
}