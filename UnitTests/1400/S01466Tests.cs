using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01466Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01466();
        Assert.That(sut.MinReorder(6, new[] {new[] {0, 1}, new[] {1, 3}, new[] {2, 3}, new[] {4, 0}, new[] {4, 5}}), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01466();
        Assert.That(sut.MinReorder(6, new[] {new[] {1, 0}, new[] {2, 0}}), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S01466();
        Assert.That(sut.MinReorder(5, new[] {new[] {1, 0}, new[] {1, 2}, new[] {3, 2}, new[] {3, 4}}), Is.EqualTo(2));
    }
}