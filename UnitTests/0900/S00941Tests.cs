using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00941Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00941();
        Assert.That(sut.ValidMountainArray(new[] {2, 1}), Is.False);
    }

    [Test]
    public void T2()
    {
        var sut = new S00941();
        Assert.That(sut.ValidMountainArray(new[] {3, 5, 5}), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S00941();
        Assert.That(sut.ValidMountainArray(new[] {0, 3, 2, 1}), Is.True);
    }
}
