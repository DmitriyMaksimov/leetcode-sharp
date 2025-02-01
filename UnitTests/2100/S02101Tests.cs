using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02101Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02101();
        Assert.That(sut.MaximumDetonation(new[] {new[] {2, 1, 3}, new[] {6, 1, 4}}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S02101();
        Assert.That(sut.MaximumDetonation(new[] {new[] {1, 1, 5}, new[] {10, 10, 5}}), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S02101();
        Assert.That(sut.MaximumDetonation(new[] {new[] {1, 2, 3}, new[] {2, 3, 1}, new[] {3, 4, 2}, new[] {4, 5, 3}, new[] {5, 6, 4}}), Is.EqualTo(5));
    }
}