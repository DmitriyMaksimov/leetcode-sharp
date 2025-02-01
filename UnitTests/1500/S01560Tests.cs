using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01560Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01560();
        Assert.That(sut.MostVisited(4, new[] {1, 3, 1, 2}), Is.EqualTo((int[]) [1, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01560();
        Assert.That(sut.MostVisited(2, new[] {2, 1, 2, 1, 2, 1, 2, 1, 2}), Is.EqualTo((int[]) [2]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01560();
        Assert.That(sut.MostVisited(7, new[] {1, 3, 5, 7}), Is.EqualTo((int[]) [1, 2, 3, 4, 5, 6, 7]));
    }
}