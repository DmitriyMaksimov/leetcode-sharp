using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01496Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01496();
        sut.IsPathCrossing("NES").Should().BeFalse();
    }

    [Test]
    public void T2()
    {
        var sut = new S01496();
        sut.IsPathCrossing("NESWW").Should().BeTrue();
    }
}