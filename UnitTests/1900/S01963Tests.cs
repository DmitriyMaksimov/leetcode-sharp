using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01963Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01963();
        Assert.That(sut.MinSwaps("][]["), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01963();
        Assert.That(sut.MinSwaps("]]][[["), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S01963();
        Assert.That(sut.MinSwaps("[]"), Is.EqualTo(0));
    }
}