using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00332Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00332();
        sut.FindItinerary(
                new IList<string>[]
                    {new[] {"MUC", "LHR"}, new[] {"JFK", "MUC"}, new[] {"SFO", "SJC"}, new[] {"LHR", "SFO"}}).Should()
            .Equal("JFK", "MUC", "LHR", "SFO", "SJC");
    }

    [Test]
    public void T2()
    {
        var sut = new S00332();
        sut.FindItinerary(
                new IList<string>[]
                {
                    new[] {"JFK", "SFO"}, new[] {"JFK", "ATL"}, new[] {"SFO", "ATL"}, new[] {"ATL", "JFK"},
                    new[] {"ATL", "SFO"}
                }).Should()
            .Equal("JFK", "ATL", "JFK", "SFO", "ATL", "SFO");
    }
}