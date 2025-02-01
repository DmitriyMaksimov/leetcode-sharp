using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00056Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00056();
        Assert.That(sut.Merge(new[] {new[] {1, 3}, new[] {2, 6}, new[] {8, 10}, new[] {15, 18}}), Is.EquivalentTo(new[] {new[] {1, 6}, new[] {8, 10}, new[] {15, 18}}));
    }

    [Test]
    public void T2()
    {
        var sut = new S00056();
        Assert.That(sut.Merge(new[] {new[] {1, 4}, new[] {4, 5}}), Is.EquivalentTo(new[] {new[] {1, 5}}));
    }
}