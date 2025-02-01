using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01496Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01496();
        Assert.That(sut.IsPathCrossing("NES"), Is.False);
    }

    [Test]
    public void T2()
    {
        var sut = new S01496();
        Assert.That(sut.IsPathCrossing("NESWW"), Is.True);
    }
}
