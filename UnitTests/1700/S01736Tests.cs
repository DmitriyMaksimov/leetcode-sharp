using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01736Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01736();
        Assert.That(sut.MaximumTime("2?:?0"), Is.EqualTo("23:50"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01736();
        Assert.That(sut.MaximumTime("0?:3?"), Is.EqualTo("09:39"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01736();
        Assert.That(sut.MaximumTime("1?:22"), Is.EqualTo("19:22"));
    }
}