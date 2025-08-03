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
            [["MUC", "LHR"], ["JFK", "MUC"], ["SFO", "SJC"], ["LHR", "SFO"]]), Is.EqualTo((string[]) ["JFK", "MUC", "LHR", "SFO", "SJC"]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00332();
        Assert.That(sut.FindItinerary(
        [
            ["JFK", "SFO"], ["JFK", "ATL"], ["SFO", "ATL"], ["ATL", "JFK"],
            ["ATL", "SFO"]
        ]), Is.EqualTo((string[]) ["JFK", "ATL", "JFK", "SFO", "ATL", "SFO"]));
    }
}
