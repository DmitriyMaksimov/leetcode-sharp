using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00458Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00458();
        Assert.That(sut.PoorPigs(4, 15, 15), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S00458();
        Assert.That(sut.PoorPigs(4, 15, 30), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S00458();
        Assert.That(sut.PoorPigs(125, 1, 4), Is.EqualTo(3));
    }
}