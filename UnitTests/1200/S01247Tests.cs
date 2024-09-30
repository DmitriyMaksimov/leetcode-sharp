using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01247Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01247();
        sut.MinimumSwap("xx", "yy").Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01247();
        sut.MinimumSwap("xy", "yx").Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01247();
        sut.MinimumSwap("xx", "xy").Should().Be(-1);
    }
}
