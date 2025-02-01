using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00062Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00062();
        Assert.That(sut.UniquePaths(3, 7), Is.EqualTo(28));
    }

    [Test]
    public void T2()
    {
        var sut = new S00062();
        Assert.That(sut.UniquePaths(3, 2), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S00062();
        Assert.That(sut.UniquePaths(1, 1), Is.EqualTo(1));
    }

    [Test]
    public void T4()
    {
        var sut = new S00062();
        Assert.That(sut.UniquePaths(1, 2), Is.EqualTo(1));
    }

    [Test]
    public void T5()
    {
        var sut = new S00062();
        Assert.That(sut.UniquePaths(2, 1), Is.EqualTo(1));
    }
}