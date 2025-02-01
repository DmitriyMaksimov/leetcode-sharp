using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01535Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01535();
        Assert.That(sut.GetWinner(new[] {2, 1, 3, 5, 4, 6, 7}, 2), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S01535();
        Assert.That(sut.GetWinner(new[] {3, 2, 1}, 10), Is.EqualTo(3));
    }
}