using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01051Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01051();
        Assert.That(sut.HeightChecker(new[] {1, 1, 4, 2, 1, 3}), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01051();
        Assert.That(sut.HeightChecker(new[] {5, 1, 2, 3, 4}), Is.EqualTo(5));
    }

    [Test]
    public void T3()
    {
        var sut = new S01051();
        Assert.That(sut.HeightChecker(new[] {1, 2, 3, 4, 5}), Is.EqualTo(0));
    }
}