using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00034Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00034();
        Assert.That(sut.SearchRange([5, 7, 7, 8, 8, 10], 8), Is.EqualTo((int[]) [3, 4]));
    }

    [Test]
    public void T2()
    {
        var sut = new S00034();
        Assert.That(sut.SearchRange([5, 7, 7, 8, 8, 10], 6), Is.EqualTo((int[]) [-1, -1]));
    }

    [Test]
    public void T3()
    {
        var sut = new S00034();
        Assert.That(sut.SearchRange([], 0), Is.EqualTo((int[]) [-1, -1]));
    }

    [Test]
    public void T4()
    {
        var sut = new S00034();
        Assert.That(sut.SearchRange([2, 2], 3), Is.EqualTo((int[]) [-1, -1]));
    }

    [Test]
    public void T5()
    {
        var sut = new S00034();
        Assert.That(sut.SearchRange([2, 2], 2), Is.EqualTo((int[]) [0, 1]));
    }
}