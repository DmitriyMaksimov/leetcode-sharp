using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00797Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00797();
        Assert.That(sut.AllPathsSourceTarget(new[] {new[] {1, 2}, new[] {3}, new[] {3}, Array.Empty<int>()}), Is.EquivalentTo(new[]{new[] {0, 1, 3}, new[] {0, 2, 3}}));
    }

    [Test]
    public void T2()
    {
        var sut = new S00797();
        Assert.That(sut.AllPathsSourceTarget(new[] {new[] {4, 3, 1}, new[] {3, 2, 4}, new[] {3}, new[] {4}, Array.Empty<int>()}), Is.EquivalentTo(new[]{new[] {0, 4}, new[] {0, 3, 4}, new[] {0, 1, 3, 4}, new[] {0, 1, 2, 3, 4}, new[] {0, 1, 4}}));
    }
}