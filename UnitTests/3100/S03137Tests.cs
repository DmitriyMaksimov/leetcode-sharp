using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03137Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03137();
        sut.MinimumOperationsToMakeKPeriodic("leetcodeleet", 4).Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S03137();
        sut.MinimumOperationsToMakeKPeriodic("leetcoleet", 2).Should().Be(3);
    }
}
