namespace leetcode_sharp;

// 2469. Convert the Temperature
// https://leetcode.com/problems/convert-the-temperature/
public class S02469
{
    public double[] ConvertTemperature(double celsius)
    {
        return new[] {celsius + 273.15, celsius * 1.80 + 32.00};
    }
}