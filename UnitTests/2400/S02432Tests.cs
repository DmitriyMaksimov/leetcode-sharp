using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02432Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02432();
        Assert.That(sut.HardestWorker(10, [[0, 3], [2, 5], [0, 9], [1, 15]]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02432();
        Assert.That(sut.HardestWorker(26, [[1, 1], [3, 7], [2, 12], [7, 17]]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S02432();
        Assert.That(sut.HardestWorker(2, [[0, 10], [1, 20]]), Is.EqualTo(0));
    }
}