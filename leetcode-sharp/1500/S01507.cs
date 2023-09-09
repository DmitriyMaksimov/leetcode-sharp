namespace leetcode_sharp;

// 1507. Reformat Date
// https://leetcode.com/problems/reformat-date/
public class S01507
{
    private readonly string[] _months = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};

    public string ReformatDate(string date)
    {
        var parts = date.Split(' ');

        var day = int.Parse(parts[0][..^2]);
        var month = Array.IndexOf(_months, parts[1]) + 1;
        var year = parts[2];

        return $"{year}-{month:D2}-{day:D2}";
    }
}