using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01529Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01529();
        sut.MinFlips("10111").Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S01529();
        sut.MinFlips("101").Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S01529();
        sut.MinFlips("00000").Should().Be(0);
    }
}