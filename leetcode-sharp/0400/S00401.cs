using System.Numerics;

namespace leetcode_sharp;

// 401. Binary Watch
// https://leetcode.com/problems/binary-watch/
public class S00401
{
    public IList<string> ReadBinaryWatch(int turnedOn)
    {
        var result = new List<string>();
        for (var h = 0; h < 12; h++)
        {
            for (var m = 0; m < 60; m++)
            {
                if (BitOperations.PopCount((uint)h) + BitOperations.PopCount((uint)m) == turnedOn)
                {
                    result.Add($"{h}:{m:D2}");
                }
            }
        }

        return result;
    }
}