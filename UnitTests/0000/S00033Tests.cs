using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00033Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00033();
        Assert.That(sut.Search(new[] {4, 5, 6, 7, 0, 1, 2}, 0), Is.EqualTo(4));
    }

    [Test]
    public void T2()
    {
        var sut = new S00033();
        Assert.That(sut.Search(new[] {4, 5, 6, 7, 0, 1, 2}, 3), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S00033();
        Assert.That(sut.Search(new[] {1}, 0), Is.EqualTo(-1));
    }
}