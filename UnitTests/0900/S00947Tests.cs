using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00947Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S00947();
        Assert.That(sut.RemoveStones(new[] {new[] {0, 0}, new[] {0, 1}, new[] {1, 0}, new[] {1, 2}, new[] {2, 1}, new[] {2, 2}}), Is.EqualTo(5));
    }

    [Test]
    public void Test2()
    {
        var sut = new S00947();
        Assert.That(sut.RemoveStones(new[] {new[] {0, 0}, new[] {0, 2}, new[] {1, 1}, new[] {2, 0}, new[] {2, 2}}), Is.EqualTo(3));
    }

    [Test]
    public void Test3()
    {
        var sut = new S00947();
        Assert.That(sut.RemoveStones(new[] {new[] {0, 0}}), Is.EqualTo(0));
    }
}