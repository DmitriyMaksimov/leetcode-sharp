using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00069Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00069();
        sut.MySqrt(4).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S00069();
        sut.MySqrt(8).Should().Be(2);
    }
}