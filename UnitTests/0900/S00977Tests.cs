using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00977Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00977();
        Assert.That(sut.SortedSquares(new[] {-4, -1, 0, 3, 10}), Is.EquivalentTo(new[] {0, 1, 9, 16, 100}));
    }

    [Test]
    public void T2()
    {
        var sut = new S00977();
        Assert.That(sut.SortedSquares(new[] {-7, -3, 2, 3, 11}), Is.EquivalentTo(new[] {4, 9, 9, 49, 121}));
    }
}