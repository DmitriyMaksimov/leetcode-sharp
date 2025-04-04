using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01033Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01033();
        Assert.That(sut.NumMovesStones(1, 2, 5), Is.EqualTo([1, 2]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01033();
        Assert.That(sut.NumMovesStones(4, 3, 2), Is.EqualTo([0, 0]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01033();
        Assert.That(sut.NumMovesStones(3, 5, 1), Is.EqualTo([1, 2]));
    }
}
