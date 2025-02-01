using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00047Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00047();
        Assert.That(sut.PermuteUnique(new[] {1, 1, 2}), Is.EquivalentTo(new[] {new[] {1, 1, 2}, new[] {1, 2, 1}, new[] {2, 1, 1}}));
    }

    [Test]
    public void T2()
    {
        var sut = new S00047();
        Assert.That(sut.PermuteUnique(new[] {1, 2, 3}), Is.EquivalentTo(new[]
        {
            new[] {1, 2, 3}, new[] {1, 3, 2}, new[] {2, 1, 3}, new[] {2, 3, 1}, new[] {3, 1, 2}, new[] {3, 2, 1}
        }));
    }
}