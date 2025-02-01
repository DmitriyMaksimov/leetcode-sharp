using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02812Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02812();
        Assert.That(sut.MaximumSafenessFactor([[1, 0, 0], [0, 0, 0], [0, 0, 1]]), Is.EqualTo(0));
    }

    [Test]
    public void T2()
    {
        var sut = new S02812();
        Assert.That(sut.MaximumSafenessFactor([[0, 0, 1], [0, 0, 0], [0, 0, 0]]), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S02812();
        Assert.That(sut.MaximumSafenessFactor([[0, 0, 0, 1], [0, 0, 0, 0], [0, 0, 0, 0], [1, 0, 0, 0]]), Is.EqualTo(2));
    }
}