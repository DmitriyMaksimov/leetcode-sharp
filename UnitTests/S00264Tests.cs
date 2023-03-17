using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00264Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00264();
        sut.NthUglyNumber(10).Should().Be(12);
    }

    [Test]
    public void T2()
    {
        var sut = new S00264();
        sut.NthUglyNumber(1).Should().Be(1);
    }
}