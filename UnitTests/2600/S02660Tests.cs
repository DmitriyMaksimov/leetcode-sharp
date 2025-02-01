using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02660Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02660();
        Assert.That(sut.IsWinner(new[] {4, 10, 7, 9}, new[] {6, 5, 2, 3}), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02660();
        Assert.That(sut.IsWinner(new[] {3, 5, 7, 6}, new[] {8, 10, 10, 2}), Is.EqualTo(2));
    }

    [Test]
    public void T3()
    {
        var sut = new S02660();
        Assert.That(sut.IsWinner(new[] {2, 3}, new[] {4, 1}), Is.EqualTo(0));
    }

    [Test]
    public void T4()
    {
        var sut = new S02660();
        Assert.That(sut.IsWinner(new[] {10, 2, 2, 3}, new[] {3, 8, 4, 5}), Is.EqualTo(1));
    }
}