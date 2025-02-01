using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01619Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01619();
        Assert.That(sut.TrimMean(new[] {1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3}), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S01619();
        Assert.That(sut.TrimMean(new[] {6, 2, 7, 5, 1, 2, 0, 3, 10, 2, 5, 0, 5, 5, 0, 8, 7, 6, 8, 0}), Is.EqualTo(4));
    }

    [Test]
    public void T3()
    {
        var sut = new S01619();
        Assert.That(sut.TrimMean(new[]
        {
            6, 0, 7, 0, 7, 5, 7, 8, 3, 4, 0, 7, 8, 1, 6, 8, 1, 1, 2, 4, 8, 1, 9, 5, 4, 3, 8, 5, 10, 8, 6, 6, 1, 0, 6,
            10, 8, 2, 3, 4
        }), Is.EqualTo(4.777777777777778));
    }
}