using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03137Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03137();
        Assert.That(sut.MinimumOperationsToMakeKPeriodic("leetcodeleet", 4), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03137();
        Assert.That(sut.MinimumOperationsToMakeKPeriodic("leetcoleet", 2), Is.EqualTo(3));
    }
}
