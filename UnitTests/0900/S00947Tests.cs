using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00947Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S00947();
        Assert.That(sut.RemoveStones([
            [0, 0], [0, 1], [1, 0], [1, 2], [2, 1], [2, 2]
        ]), Is.EqualTo(5));
    }

    [Test]
    public void Test2()
    {
        var sut = new S00947();
        Assert.That(sut.RemoveStones([[0, 0], [0, 2], [1, 1], [2, 0], [2, 2]]), Is.EqualTo(3));
    }

    [Test]
    public void Test3()
    {
        var sut = new S00947();
        Assert.That(sut.RemoveStones([[0, 0]]), Is.EqualTo(0));
    }
}