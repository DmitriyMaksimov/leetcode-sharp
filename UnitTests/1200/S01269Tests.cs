using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01269Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01269();
        sut.NumWays(3, 2).Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S01269();
        sut.NumWays(2, 4).Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01269();
        sut.NumWays(4, 2).Should().Be(8);
    }
}