using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02432Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02432();
        Assert.That(sut.HardestWorker(10, new[] {new[] {0, 3}, new[] {2, 5}, new[] {0, 9}, new[] {1, 15}}), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S02432();
        Assert.That(sut.HardestWorker(26, new[] {new[] {1, 1}, new[] {3, 7}, new[] {2, 12}, new[] {7, 17}}), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S02432();
        Assert.That(sut.HardestWorker(2, new[] {new[] {0, 10}, new[] {1, 20}}), Is.EqualTo(0));
    }
}