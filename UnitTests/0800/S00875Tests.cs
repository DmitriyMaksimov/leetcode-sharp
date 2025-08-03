using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00875Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00875();
        Assert.That(sut.MinEatingSpeed([3, 6, 7, 11], 8), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00875();
        Assert.That(sut.MinEatingSpeed([30, 11, 23, 4, 20], 5), Is.EqualTo(30));
    }

    [Test]
    public void T3()
    {
        var sut = new S00875();
        Assert.That(sut.MinEatingSpeed([30, 11, 23, 4, 20], 6), Is.EqualTo(23));
    }
}