using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00788Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00788();
        sut.RotatedDigits(10).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S00788();
        sut.RotatedDigits(1).Should().Be(0);
    }

    [Test]
    public void T3()
    {
        var sut = new S00788();
        sut.RotatedDigits(2).Should().Be(1);
    }
}
