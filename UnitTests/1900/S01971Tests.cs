using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01971Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01971();
        Assert.That(sut.ValidPath(3, new[] {new[] {0, 1}, new[] {1, 2}, new[] {2, 0}}, 0, 2), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01971();
        Assert.That(sut.ValidPath(6, new[] {new[] {0, 1}, new[] {0, 2}, new[] {3, 5}, new[] {5, 4}, new[] {4, 3}}, 0, 5), Is.False);
    }
}
