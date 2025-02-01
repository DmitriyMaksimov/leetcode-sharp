using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00332Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00332();
        Assert.That(sut.FindItinerary(
                new IList<string>[]
                    {new[] {"MUC", "LHR"}, new[] {"JFK", "MUC"}, new[] {"SFO", "SJC"}, new[] {"LHR", "SFO"}}), Is.EqualTo((string[]) ["JFK", "MUC", "LHR", "SFO", "SJC"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00332();
        Assert.That(sut.FindItinerary(
                new IList<string>[]
                {
                    new[] {"JFK", "SFO"}, new[] {"JFK", "ATL"}, new[] {"SFO", "ATL"}, new[] {"ATL", "JFK"},
                    new[] {"ATL", "SFO"}
                }), Is.EqualTo((string[]) ["JFK", "ATL", "JFK", "SFO", "ATL", "SFO"]));
    }
}
