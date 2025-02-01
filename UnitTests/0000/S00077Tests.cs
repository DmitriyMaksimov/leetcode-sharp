using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00077Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00077();
        Assert.That(sut.Combine(4, 2), Is.EquivalentTo(new[] {new[] {1, 2}, new[] {1, 3}, new[] {1, 4}, new[] {2, 3}, new[] {2, 4}, new[] {3, 4}}));
    }

    [Test]
    public void T2()
    {
        var sut = new S00077();
        Assert.That(sut.Combine(1, 1), Is.EquivalentTo(new[] {new[] {1}}));
    }
}