using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01046Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01046();
        Assert.That(sut.LastStoneWeight(new[] {2, 7, 4, 1, 8, 1}), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S01046();
        Assert.That(sut.LastStoneWeight(new[] {1}), Is.EqualTo(1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01046();
        Assert.That(sut.LastStoneWeight(new[] {1, 3}), Is.EqualTo(2));
    }

    [Test]
    public void T4()
    {
        var sut = new S01046();
        Assert.That(sut.LastStoneWeight(new[] {2, 2}), Is.EqualTo(0));
    }

    [Test]
    public void T5()
    {
        var sut = new S01046();
        Assert.That(sut.LastStoneWeight(new[] {3, 7, 2}), Is.EqualTo(2));
    }

    [Test]
    public void T6()
    {
        var sut = new S01046();
        Assert.That(sut.LastStoneWeight(new[] {3, 7, 8}), Is.EqualTo(2));
    }

    [Test]
    public void T7()
    {
        var sut = new S01046();
        Assert.That(sut.LastStoneWeight(new[] {9, 10, 1, 7, 3}), Is.EqualTo(2));
    }
}