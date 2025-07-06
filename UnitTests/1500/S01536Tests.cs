using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01536))]
public class S01536Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01536();
        Assert.That(sut.MinSwaps([[0, 0, 1], [1, 1, 0], [1, 0, 0]]), Is.EqualTo(3));
    }

    [Test]
    public void T2()
    {
        var sut = new S01536();
        Assert.That(sut.MinSwaps([[0, 1, 1, 0], [0, 1, 1, 0], [0, 1, 1, 0], [0, 1, 1, 0]]), Is.EqualTo(-1));
    }

    [Test]
    public void T3()
    {
        var sut = new S01536();
        Assert.That(sut.MinSwaps([[1, 0, 0], [1, 1, 0], [1, 1, 1]]), Is.EqualTo(0));
    }
}