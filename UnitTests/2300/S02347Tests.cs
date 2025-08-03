using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02347Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02347();
        Assert.That(sut.BestHand([13, 2, 3, 1, 9], ['a', 'a', 'a', 'a', 'a', 'a']), Is.EqualTo("Flush"));
    }

    [Test]
    public void T2()
    {
        var sut = new S02347();
        Assert.That(sut.BestHand([4, 4, 2, 4, 4], ['d', 'a', 'a', 'b', 'c']), Is.EqualTo("Three of a Kind"));
    }

    [Test]
    public void T3()
    {
        var sut = new S02347();
        Assert.That(sut.BestHand([10, 10, 2, 12, 9], ['a', 'b', 'c', 'a', 'd']), Is.EqualTo("Pair"));
    }
}