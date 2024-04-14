using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01963Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01963();
        sut.MinSwaps("][][").Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01963();
        sut.MinSwaps("]]][[[").Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S01963();
        sut.MinSwaps("[]").Should().Be(0);
    }
}