namespace leetcode_sharp;

// 2125. Number of Laser Beams in a Bank
// https://leetcode.com/problems/number-of-laser-beams-in-a-bank
public class S02125
{
    public int NumberOfBeams(string[] bank)
    {
        var count = 0;
        var prev = 0;
        
        foreach (var floor in bank)
        {
            var ones = floor.Count(c => c == '1');
            if (ones != 0)
            {
                count += ones * prev;
                prev = ones;
            }
        }

        return count;
    }
}