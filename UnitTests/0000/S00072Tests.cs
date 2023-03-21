using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00072Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00072();
        sut.MinDistance("horse", "ros").Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00072();
        sut.MinDistance("intention", "execution").Should().Be(5);
    }
}