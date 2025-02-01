using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00649Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00649();
        Assert.That(sut.PredictPartyVictory("RD"), Is.EqualTo("Radiant"));
    }

    [Test]
    public void T2()
    {
        var sut = new S00649();
        Assert.That(sut.PredictPartyVictory("RDD"), Is.EqualTo("Dire"));
    }
}