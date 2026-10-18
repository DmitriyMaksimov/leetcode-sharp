namespace leetcode_sharp;

// 3894. Traffic Signal Color
// https://leetcode.com/problems/traffic-signal-color
public class S03894
{
    public string TrafficSignal(int timer)
    {
        return timer switch
        {
            0 => "Green",
            30 => "Orange",
            > 30 and <= 90 => "Red",
            _ => "Invalid"
        };
    }
}