using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00802Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00802();
        Assert.That(sut.EventualSafeNodes(
            new[] {new[] {1, 2}, new[] {2, 3}, new[] {5}, new[] {0}, new []{5}, Array.Empty<int>(), Array.Empty<int>()}), Is.EqualTo((int[]) [2, 4, 5, 6]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00802();
        Assert.That(sut.EventualSafeNodes(new[] {new[] {1, 2, 3, 4}, new[] {1, 2}, new[] {3, 4}, new[] {0, 4}, Array.Empty<int>()}), Is.EqualTo((int[]) [4]));
    }
}