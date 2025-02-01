using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01200Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01200();
        Assert.That(sut.MinimumAbsDifference(new[] {4, 2, 1, 3}), Is.EquivalentTo(new[] {new[] {1, 2}, new[] {2, 3}, new[] {3, 4}}));
    }

    [Test]
    public void T2()
    {
        var sut = new S01200();
        Assert.That(sut.MinimumAbsDifference(new[] {1, 3, 6, 10, 15}), Is.EquivalentTo(new[] {new[] {1, 3}}));
    }

    [Test]
    public void T3()
    {
        var sut = new S01200();
        Assert.That(sut.MinimumAbsDifference(new[] {3, 8, -10, 23, 19, -4, -14, 27}), Is.EquivalentTo(new[] {new[] {-14, -10}, new[] {19, 23}, new[] {23, 27}}));
    }
}