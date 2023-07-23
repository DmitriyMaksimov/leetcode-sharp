using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00649Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00649();
        sut.PredictPartyVictory("RD").Should().Be("Radiant");
    }

    [Test]
    public void T2()
    {
        var sut = new S00649();
        sut.PredictPartyVictory("RDD").Should().Be("Dire");
    }
}