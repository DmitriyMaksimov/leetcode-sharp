using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02147Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02147();
        sut.NumberOfWays("SSPPSPS").Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S02147();
        sut.NumberOfWays("PPSPSP").Should().Be(1);
    }

    [Test]
    public void T3()
    {
        var sut = new S02147();
        sut.NumberOfWays("S").Should().Be(0);
    }
}