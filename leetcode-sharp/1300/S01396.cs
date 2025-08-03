namespace leetcode_sharp;

// 1396. Design Underground System
// https://leetcode.com/problems/design-underground-system/
public static class S01396
{
public class UndergroundSystem
{
    private readonly Dictionary<int, (string stationName, int t)> _checkInTimes = new();    // card id => (station name, check in time)
    private readonly Dictionary<string, List<int>> _timeBetweenStations = new();    // "From_To" => list of durations

    public void CheckIn(int id, string stationName, int t)
    {
        _checkInTimes[id] = (stationName, t);
    }

    public void CheckOut(int id, string stationName, int t)
    {
        var (fromStationName, checkInTime) = _checkInTimes[id];
        var fromToKey = getKey(fromStationName, stationName);
        var list = _timeBetweenStations.GetValueOrDefault(fromToKey, []);
        list.Add(t - checkInTime);
        _timeBetweenStations[fromToKey] = list;
    }

    public double GetAverageTime(string startStation, string endStation)
    {
        var fromToKey = getKey(startStation, endStation);
        return _timeBetweenStations[fromToKey].Average();
    }

    private static string getKey(string startStation, string endStation) => $"{startStation}_{endStation}";
}
}