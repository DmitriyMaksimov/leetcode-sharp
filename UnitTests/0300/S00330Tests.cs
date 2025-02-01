using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00330Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00330();
        Assert.That(sut.MinPatches([1, 3], 6), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S00330();
        Assert.That(sut.MinPatches([1, 5, 10], 20), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S00330();
        Assert.That(sut.MinPatches([1, 2, 2], 5), Is.EqualTo(0));
    }
}